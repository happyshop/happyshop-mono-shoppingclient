using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HappyShop.ServiceConnector;
using log4net;

namespace HappyShop.ShoppingClient.ImageCaching
{
  public abstract class LocalImageCache : ILocalImageCache
  {
    private static readonly ILog Log = LogManager.GetLogger("LocalImageCache");

    private readonly IConnector _connector;

    protected LocalImageCache(IConnector connector)
    {
      _connector = connector;
    }

    protected string MakeName(string barcode)
    {
      return string.Format("{0}.img", barcode);
    }

    public abstract bool Has(string barcode);
    protected abstract Stream AsReadStream(string barcode);
    protected abstract Stream AsWriteStream(string barcode);

    public Stream Get(string barcode)
    {
      if (!Has(barcode))
      {
        throw new ArgumentOutOfRangeException("barcode", string.Format("no image exists for barcode '{0}'", barcode));
      }

      return AsReadStream(barcode);
    }

    public bool Compare(string barcode, Stream source)
    {
      if (Has(barcode))
      {
        return Get(barcode).ToArray().SequenceEqual(source.ToArray());
      }
      return false;
    }

    public void Put(string barcode, Stream source)
    {
      using (Stream target = AsWriteStream(barcode))
      {
        source.Rewind().CopyTo(target);
      }
    }

    public virtual void Synchronize()
    {
      try
      {
        _connector.GetItemIds().ToList()
          .ForEach(id => Put(id, _connector.GetImage(id)));
      }
      catch( Exception exception )
      {
        Log.Error("Failed to synchronize cache", exception);
      }
    }
  }
}