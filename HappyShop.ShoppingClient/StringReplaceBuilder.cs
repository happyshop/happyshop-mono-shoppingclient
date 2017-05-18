using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyShop.ShoppingClient
{
  public class StringReplaceBuilder
  {
    public StringReplaceBuilder()
    {
    }

    private string _text;

    public StringReplaceBuilder AddText(string text)
    {
      _text = text;
      return this;
    }

    public StringReplaceBuilder AddReplacement(string pattern, string replacement)
    {
      _text = _text.Replace(pattern, replacement);
      return this;
    }

    public override string ToString()
    {
      return _text;
    }
  }
}
