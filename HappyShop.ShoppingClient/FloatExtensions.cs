using System;
using System.Globalization;

namespace HappyShop.ShoppingClient
{
  public static class FloatExtensions
  {
    static public string AsPrice(this float @this, string culture = "de-DE")
    {
      CultureInfo cultureInfo = culture != null ? CultureInfo.GetCultureInfo(culture) : CultureInfo.InvariantCulture;
      return Math.Abs(@this) < 1.0f ? string.Format("{0} ¢", (@this * 100).ToString("F0", cultureInfo)) : string.Format("{0} €", @this.ToString("F2", cultureInfo));
    }
  }
}