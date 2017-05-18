using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace HappyShop.ShoppingClient
{
  public partial class ErrorBox : UserControl
  {
    private readonly Form _parentForm;
    private readonly Action _keepActive = () => {};
    private Timer _keepActiveTimer;
    private IDisposable _locker;

    public ErrorBox(Form parentForm, ActivationGuard activationGuard, StateMachine stateMachine)
    {
      _parentForm = parentForm;
      _locker = stateMachine.Lock();

      if( activationGuard != null )
      {
        _keepActive = activationGuard.ActivityDetected;
      }

      InitializeComponent();

      if (_parentForm != null)
      {
        _parentForm.Controls.Add(this);
        Enabled = true;
        Visible = true;
        UpdateZOrder();
      }
    }

    private static T AppSettingsWithDefault<T>(string name, Func<string, T> valueConverter, T defaultValue)
    {
      try
      {
        var dict = (IDictionary <string, object>)Configuration.Static.Merged;
        return valueConverter((string)dict[name]);
      }
      catch(Exception)
      {
        return defaultValue;
      }
    }

    public ErrorBox WithMessage(string message)
    {
      labelMessage.Text = message;
      return this;
    }
    
    private void ErrorBox_Load(object sender, EventArgs e)
    {
      BringToFront();


      

      Timer offTimer = new Timer { Interval = AppSettingsWithDefault("ShowErrorMessageFor", s => (int)TimeSpan.Parse(s).TotalMilliseconds, 10000) };
      offTimer.Tick += (o, args) =>
                                  {
                                    ((Timer)o).Dispose();
                                    _keepActiveTimer.Dispose();
                                    ByeBye();
                                  };
      _keepActiveTimer = new Timer { Interval = AppSettingsWithDefault("InactivityTimeout", s => (int)(TimeSpan.Parse(s).TotalMilliseconds / 2), 10000) };
      _keepActiveTimer.Tick += (o, args) => _keepActive();

      offTimer.Start();
      _keepActiveTimer.Start();
    }

    private void ByeBye()
    {
      if( _parentForm != null )
      {
        _parentForm.Controls.Remove(this);
      }
      Dispose();
      _locker.Dispose();
    }
  }
}
