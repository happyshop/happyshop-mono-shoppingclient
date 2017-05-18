using System;
using System.Drawing;
using System.Windows.Forms;
using HappyShop.Model;
using HappyShop.ServiceConnector;
using HappyShop.ShoppingClient.ImageCaching;
using log4net;
using log4net.Repository.Hierarchy;

namespace HappyShop.ShoppingClient
{
  public partial class FinishedScreen : UserControl, IState
  {
    private static readonly ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public FinishedScreen()
    {
      InitializeComponent();
    }

    public States State
    {
      get
      {
        return States.Finished;
      }
    }

    public void Deactivate()
    {
      UiScope.OnScope(this, () =>
      {
        pictureBoxItemImage.Image = null;
        Enabled = false;
        Visible = false;
      });
    }

    public ImageCache ImageCache
    {
      get;
      set;
    }

    public void Activate(User user, Item item)
    {
      UiScope.OnScope(this, () =>
      {
        Enabled = true;
        Visible = true;

        labelItemDescription.Text = item.Description;
        labelItemPrice.Text = string.Format("für {0}", item.Price.AsPrice());
        labelBalance.ForeColor = user.Balance >= 0.0f ? Color.Black : Color.Red;
        labelBalance.Text = string.Format("Dein {1}: {0}", user.Balance.AsPrice(), user.Balance >= 0.0f ? "Guthaben" : "Minus");

        Image image = ImageCache.Get(item.Barcode);
        if (image != null)
        {
          pictureBoxItemImage.Image = image;
          pictureBoxItemImage.Visible = true;
        }
        else
        {
          pictureBoxItemImage.Visible = false;
        }
      });

      SendInfoMail(user, item);
        SendBalanceWarningMail(user);
    }

    private static void SendBalanceWarningMail(User user)
    {
      if( user.Balance < 0.0f )
      {
        try
        {
          new SimpleSmtpClient("Du bist leider im Minus! ", user.Mail)
            .AddBody("Bitte denke da dran, Dein Konto bei Gelegenheit wieder aufzufüllen, damit Du (und damit auch wir als Betreiber) weiter leckerste Leckereien einkaufen kannst.")
            .AddBody("Dein Minus: {0}", user.Balance.AsPrice())
            .Send();
        }
        catch( Exception exception )
        {
          _log.Error(exception);
        }
      }
    }

    private static void SendInfoMail(User user, Item item)
    {
      try
      {
        new SimpleSmtpClient("Vielen Dank für deinen Einkauf im Mitarbeiter-Kiosk.", user.Mail)
          .AddBody("Dein Einkauf: {0}", item.Description)
          .AddBody("Preis: {0}", item.Price.AsPrice())
          .AddBody("Dein neuer Kontostand: {0}", user.Balance.AsPrice())
          .Send();
      }
      catch( Exception exception )
      {
        _log.Error(exception);
      }
    }

  }
}
