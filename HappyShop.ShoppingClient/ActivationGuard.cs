using System;
using System.Collections.Generic;
using System.Timers;

namespace HappyShop.ShoppingClient
{
  public class ActivationGuard : IDisposable
  {
    private readonly IErrorProvider _errorProvider;
    private readonly List<Action> _activateCallbacks = new List<Action>();
    private readonly List<Action> _deactivateCallbacks = new List<Action>();
 
    private readonly Timer _inactivityTimer;
    private readonly object _lockObject = new object();

    public ActivationGuard(TimeSpan inactivityTimeout, IErrorProvider errorProvider)
    {
      _errorProvider = errorProvider;
      _inactivityTimer = new Timer(inactivityTimeout.TotalMilliseconds);
      _inactivityTimer.Elapsed += InactivityTimerOnElapsed;
    }

    public void Start()
    {
      _state = true;
      Activate();
      _inactivityTimer.Start();
    }

    public ActivationGuard OnActivate(Action action)
    {
      _activateCallbacks.Add(action);
      return this;
    }

    public ActivationGuard OnDeactivate(Action action)
    {
      _deactivateCallbacks.Add(action);
      return this;
    }

    private void InactivityTimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
    {
      lock (_lockObject)
      {
        _state = false;
        Deactivate();
        _inactivityTimer.Stop();
      }
    }

    private void Activate()
    {
      _errorProvider.DoWith(() => _activateCallbacks.ForEach(action => action()), "Failed to activate activity timer");
    }

    private void Deactivate()
    {
      _errorProvider.DoWith(() => _deactivateCallbacks.ForEach(action => action()), "Failed to deactivate activity timer");
    }

    public void ActivityDetected()
    {
      lock (_lockObject)
      {
        if (! _state)
        {
          Activate();
          _state = true;
        }

        _inactivityTimer.Stop();
        _inactivityTimer.Start();
      }
    }

    private bool _state;

    public void Dispose()
    {
      lock (_lockObject)
      {
        if (_inactivityTimer.Enabled)
        {
          _inactivityTimer.Stop();
          _inactivityTimer.Dispose();
        }
        Activate();
      }
    }
  }
}