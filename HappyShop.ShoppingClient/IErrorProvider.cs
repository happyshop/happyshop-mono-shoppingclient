using System;

namespace HappyShop.ShoppingClient
{
  public interface IErrorProvider
  {
    void Error(Exception exception, string format, params object[] args);
    void Error(Exception exception);
    void DoWith(Action actionWithErrorHandling);
    void DoWith(Action actionWithErrorHandling, string format, params object[] args);

  }
}