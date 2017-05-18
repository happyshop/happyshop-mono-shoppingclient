using System;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Forms;
using HappyShop.Model;
using HappyShop.ShoppingClient.ImageCaching;

namespace HappyShop.ShoppingClient
{
  public partial class PriceInfoScreen : UserControl, IState
  {
    public PriceInfoScreen()
    {
      InitializeComponent();
    }

    public States State
    {
      get
      {
        return States.PriceInfo;
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
    }
  }
}
