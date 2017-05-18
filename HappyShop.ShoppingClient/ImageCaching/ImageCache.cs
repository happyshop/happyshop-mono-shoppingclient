using System.Collections.Generic;
using System.Drawing;

namespace HappyShop.ShoppingClient.ImageCaching
{
  public class ImageCache
  {
    private readonly ILocalImageCache _localCache;

    public ImageCache(ILocalImageCache localCache)
    {
      _localCache = localCache;
    }

    private readonly Dictionary<string,Image> _cache = new Dictionary<string, Image>();
    private readonly object _lockObject = new object();

    public Image Get(string barcode)
    {
      lock ( _lockObject )
      {
        Image image;

        if( !_cache.TryGetValue(barcode, out image) )
        {
          image = Load(barcode);
          _cache.Add(barcode, image);
        }
        return image;
      }
    }

    public void Synchronize()
    {
      lock ( _lockObject )
      {
        _cache.Clear();
        _localCache.Synchronize();
      }
    }

    private Image Load(string barcode)
    {
      if( _localCache.Has(barcode) )
      {
        return Image.FromStream(_localCache.Get(barcode));
      }
      return null;
    }
  }
}