using System;
using HappyShop.Model;
using HappyShop.ServiceConnector;
using System.Windows.Forms;

namespace HappyShop.ShoppingClient
{
  public class StateMachine
  {
    private class Locker : IDisposable
    {
      private readonly StateMachine _this;

      public Locker(StateMachine @this)
      {
        _this = @this;
        _this._lockCounter++;
      }

      public void Dispose()
      {
        _this._lockCounter--;
      }
    }

    private ushort _lockCounter;

    private bool IsLocked
    {
      get
      {
        return _lockCounter > 0;
      }
    }

    private User _currentUser;
    private Item _currentItem;
    private readonly Func<States, IState> _stateProvider;
    private readonly IConnector _connector;

    private readonly BarcodeScanner _scanner;
    private readonly IErrorProvider _errorProvider;
    private IState _currentState;

    public StateMachine(Func<States, IState> stateProvider, IConnector connector, BarcodeScanner scanner, IErrorProvider errorProvider)
    {
      _stateProvider = stateProvider;
      _connector = connector;
      _scanner = scanner;
      _errorProvider = errorProvider;
      _scanner.BarcodeReceived += HandleInput;
      SwitchToState(States.Welcome);
    }

    public IDisposable Lock()
    {
      return new Locker(this);
    }

    public event Action<IState> StateChanged;

    private void HandleInput(object sender, string barcode)
    {
      if(IsLocked)
      {
        // ignore inputs when locked
        return;
      }

      _errorProvider.DoWith(() =>
      {
        Barcode code = new Barcode(barcode);

        switch (code.Type)
        {
          case Barcode.Types.User:
            _currentUser = _connector.GetUser(code.BarCode);
            if (_currentUser == null)
            {
              SwitchToState(States.Welcome);
            }
            else
            {
              SwitchToState(States.Shopping);
            }
            break;
          case Barcode.Types.Item:
            if (_currentState.State == States.Shopping)
            {
              var response = _connector.OrderItem(_currentUser.Short, barcode);
              _currentUser = response.User;
              _currentItem = response.Item;
              if( _currentItem != null && _currentUser != null )
              {
                SwitchToState(States.Finished);
              }
              else
              {
                throw new UnknownItemException(barcode);
              }
            }
            else
            {
              _currentUser = null;
              _currentItem = _connector.GetItem(barcode);
              SwitchToState(_currentItem != null ? States.PriceInfo : States.Welcome);
            }
            break;
          case Barcode.Types.Command:
            if (barcode.Trim().ToUpperInvariant() == "UPDATE")
            {
              Application.Exit();
            }
            else if (barcode.Trim().ToUpperInvariant() == "STOCK")
            {
              SwitchToState(States.StockItems);
            }
            break;
          default:
            throw new ArgumentOutOfRangeException();
        }
      }, "Handle input of barcode {0} failed", barcode);
    }

    private void DeactivateCurrent()
    {
      if (_currentState != null)
      {
        _errorProvider.DoWith(_currentState.Deactivate);
      }
    }

    private void SwitchToState(States state)
    {
      _errorProvider.DoWith(() =>
      {
        DeactivateCurrent();
        _currentState = _stateProvider(state);
        _currentState.Activate(_currentUser, _currentItem);
        RaiseStateChanged();
      });
    }

    private void RaiseStateChanged()
    {
      if (StateChanged != null)
      {
        StateChanged(_currentState);
      }
    }

    public void KeyReceived(char key)
    {
      _scanner.InputReceived(key);
    }

    public void Reset()
    {
      _errorProvider.DoWith(() =>
      {
        _scanner.Reset();
        SwitchToState(States.Welcome);
      });
    }
  }
}