using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
  public class Starter
  {
    private static Shop[] Cart = new Shop[Config.cartSize];
    private static Tuple<uint, string> _checkout;

    public static void Run()
    {
      Cart = Order.AddToCart(Shop.catalogue, Cart);
      _checkout = Order.Checkout(Cart);
      NotificationManager.CheckoutPopup(_checkout.Item2, Client.clientName, Client.clientEmail, Client.clientPhone, _checkout.Item1);
    }

  }
}
