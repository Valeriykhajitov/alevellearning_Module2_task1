using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module2HW2
{
  public class Cart
  {
    static Cart()
    {
    }

    private Cart()
    {

    }

    public static Cart Instance => Instance;

    public static Shop[] AddToCart(Shop[] goods, Shop[] cart)
    {
      var index = 0;
      for (var x = 0; x < goods.Length; x++)
      {
        if (goods[x].IsExist)
        {
          cart[index] = goods[x];
          index++;
        }


      }

      return cart;
    }

    public static Tuple<uint, string> Checkout(Shop[] cart)
    {
      uint sum = 0;
      StringBuilder sb = new StringBuilder();

      for (int i = 0; i < cart.Length; i++)
      {
        if (cart[i].IsExist)
        {
          sum = cart[i].Price + sum;
          sb.AppendLine();
          sb.AppendLine(cart[i].Name.ToString());
          sb.Append(cart[i].Price.ToString());
          sb.Append(cart[i].Currency.ToString());
        }

      }

      return Tuple.Create(sum, sb.ToString());
    }
  }
}