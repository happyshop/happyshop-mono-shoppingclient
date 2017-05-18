using System.Windows.Forms;
using HappyShop.Model;

namespace HappyShop.ShoppingClient
{
  public partial class ShoppingScreen : UserControl, IState
  {
    public ShoppingScreen()
    {
      InitializeComponent();
    }

    public States State
    {
      get
      {
        return States.Shopping;
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
        labelUserName.Text = string.Format("Hallo {0}!", user.Name);
      });
    }
  }
}
