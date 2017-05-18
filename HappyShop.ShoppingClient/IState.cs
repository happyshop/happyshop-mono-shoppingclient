using System;
using HappyShop.Model;

namespace HappyShop.ShoppingClient
{
  public interface IState
  {
    States State
    {
      get;
    }

    void Deactivate();
    void Activate(User user, Item item);

  }
}