using System;
using System.Windows.Forms;

namespace HappyShop.ShoppingClient
{
  public static class UiScope
  {
    static public void OnScope(UserControl control, Action action)
    {
      if( control.InvokeRequired )
      {
        control.EndInvoke(control.BeginInvoke(new MethodInvoker(action)));
      }
      else
      {
        action();
      }
    }
  }
}