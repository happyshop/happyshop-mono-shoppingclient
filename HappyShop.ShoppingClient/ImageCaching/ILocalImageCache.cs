using System.IO;
using System.Threading.Tasks;

namespace HappyShop.ShoppingClient.ImageCaching
{
  public interface ILocalImageCache
  {
    bool Has(string barcode);
    Stream Get(string barcode);
    void Put(string barcode, Stream source);
    bool Compare(string barcode, Stream source);
    void Synchronize();
  }
}