using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
  public class Order
  {

    public static Shop[] AddToCart(Shop[] goods, Shop[] cart)
    {
      var index = 0;
      for (var x = 0; x < goods.Length; x++)
      {
        if (goods[x].isExist)
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
        if (cart[i].isExist)
        {
          sum = cart[i].price + sum;
          sb.AppendLine();
          sb.AppendLine(cart[i].name.ToString());
          sb.Append(cart[i].price.ToString());
          sb.Append(cart[i].currency.ToString());
        }

      }

      return Tuple.Create(sum, sb.ToString());
    }
  }
}
