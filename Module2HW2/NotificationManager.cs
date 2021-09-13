using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
  public class NotificationManager
  {
    private static uint CheckoutID;

    public static void CheckoutPopup(string order, string name, string email, string phoneNumber, uint total)
    {
      CheckoutID++;
      Console.WriteLine(
          $"Greetings {name}! Your order №{CheckoutID} is processed and about to be sent. We have sent you the details to your {email} email address, and to {phoneNumber} phone." +
          $"{Environment.NewLine}Please check your order and reach out to us if we have missed something: {Environment.NewLine} {order} " +
          $"{Environment.NewLine}Your checkout total is: {total}{Config.Currency.UAH} ");
    }
  }
}
