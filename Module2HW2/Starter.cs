using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
  public class Starter
  {
    private static Shop[] _cart = new Shop[Config.CartSize];
    private static Tuple<uint, string> _checkout;

    public static void Run()
    {
      _cart = Cart.AddToCart(Shop.Catalogue, _cart);
      _checkout = Cart.Checkout(_cart);
      NotificationManager.CheckoutPopup(_checkout.Item2, Config.clientName, Config.clientEmail, Config.clientPhone, _checkout.Item1);
    }

  }
}
