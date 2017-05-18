using System;
using System.Text;
using log4net;

namespace HappyShop.ShoppingClient
{
  public class BarcodeScanner
  {
    private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    public event EventHandler<string> BarcodeReceived;
    private readonly StringBuilder _barcodeBuilder = new StringBuilder();

    private void RaiseEvent()
    {
      Log.InfoFormat("Barcode received: {0}", _barcodeBuilder);
      if (BarcodeReceived != null)
      {
        string code = _barcodeBuilder.ToString().Trim();
        if (!string.IsNullOrEmpty(code) && !string.IsNullOrWhiteSpace(code))
        {
          BarcodeReceived(this, code);
        }
      }
    }

    public void InputReceived(char receivedCharacter)
    {
      if (receivedCharacter == 0x0d)
      {
        RaiseEvent();
        Reset();
      }
      else if (char.IsLetterOrDigit(receivedCharacter))
      {
        _barcodeBuilder.Append(receivedCharacter);
      }
      else if (!char.IsWhiteSpace(receivedCharacter))
      {
        Reset();
      }
    }

    public void Reset()
    {
      _barcodeBuilder.Clear();
    }
  }
}