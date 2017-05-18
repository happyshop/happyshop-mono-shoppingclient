using System;

namespace HappyShop.ShoppingClient
{
  public class UnknownItemException : Exception
  {
    public UnknownItemException(string barcode)
      : base(string.Format("Eine Leckerei mit dem Barcode '{0}' gibt es leider nicht im Kiosk. Fragt bitte mal beim Kiosk-Team nach.", barcode))
    {
    }
  }
}