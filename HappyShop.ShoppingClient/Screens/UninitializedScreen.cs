using System;
using System.Windows.Forms;
using HappyShop.Model;

namespace HappyShop.ShoppingClient
{
  public partial class UninitializedScreen : UserControl, IState
  {
    public UninitializedScreen()
    {
      InitializeComponent();
    }

    public States State
    {
      get
      {
        return States.Welcome;
      }
    }

    public void Process(Barcode barcode)
    {
      
    }

    public void Deactivate()
    {
      Enabled = false;
      Visible = false;
    }

    public void Activate(User user, Item item)
    {
      Enabled = true;
      Visible = true;
    }
  }
}
