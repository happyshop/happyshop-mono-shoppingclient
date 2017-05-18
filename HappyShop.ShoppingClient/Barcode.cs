using System;

namespace HappyShop.ShoppingClient
{
  public class Barcode
  {
    public enum Types
    {
      User,
      Command,
      Item
    }

    private readonly string _barCode;
    private readonly Types _type;

    public string BarCode
    {
      get { return _barCode; }
    }

    public Types Type
    {
      get { return _type; }
    }

    public Barcode(string barCode)
    {
      _barCode = barCode;
      _type = TypeFromCode(barCode);
    }

    private Types TypeFromCode(string barCode)
    {
      if (barCode.Length == 3)
      {
        return Types.User;
      }
      Int64 number;
      if (Int64.TryParse(barCode, out number))
      {
        return Types.Item;
      }
      return Types.Command;
    }
  }
}