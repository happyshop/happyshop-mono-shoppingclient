using System;
using System.IO;
using System.Linq;
using HappyShop.ServiceConnector;

namespace HappyShop.ShoppingClient.ImageCaching
{
  public class LocalFileImageCache : LocalImageCache
  {
    private readonly DirectoryInfo _root;

    public LocalFileImageCache(DirectoryInfo root, IConnector connector)
      : base(connector)
    {
      _root = root;

      if( ! _root.Exists )
      {
       _root.Create(); 
      }
    }

    private FileInfo MakeFile(string barcode)
    {
      return new FileInfo(Path.Combine(_root.FullName, MakeName(barcode)));
    }

    public override bool Has(string barcode)
    {
      return MakeFile(barcode).Exists;
    }

    protected override Stream AsReadStream(string barcode)
    {
      return MakeFile(barcode).OpenRead();
    }

    public override void Synchronize()
    {
      _root.GetFiles("*.img").ToList().ForEach(info => info.Delete());
      base.Synchronize();
    }

    protected override Stream AsWriteStream(string barcode)
    {
      return MakeFile(barcode).OpenWrite();
    }
  }
}