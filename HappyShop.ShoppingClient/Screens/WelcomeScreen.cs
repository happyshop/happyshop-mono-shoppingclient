using System.Windows.Forms;
using HappyShop.Model;

namespace HappyShop.ShoppingClient
{
  public partial class WelcomeScreen : UserControl, IState
  {
    public WelcomeScreen()
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

    public void Deactivate()
    {
      UiScope.OnScope(this, () =>
      {
        Enabled = false;
        Visible = false;
      });
    }

    public void Activate(User user, Item item)
    {
      UiScope.OnScope(this, () =>
      {
        Enabled = true;
        Visible = true;
      });
    }
  }
}
