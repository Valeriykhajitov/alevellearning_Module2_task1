using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
  public class Shop
  {

    Guid ID;

    public string name { get; set; }

    public uint price { get; set; }

    public bool isExist { get; set; }

    public Config.Currency currency { get; set; }


    public Shop(Guid ID, string name, uint price, bool isExist, Config.Currency currency)
    {
      ID = Guid.NewGuid();
      name = this.name;
      price = this.price;
      isExist = true;
      currency = this.currency;
    }

    public Shop()
    {
    }

    static Shop shtuka = new Shop() { ID = Guid.NewGuid(), name = "shtuka", price = 220, isExist = true, currency = Config.Currency.UAH };
    static Shop otherShtuka = new Shop() { ID = Guid.NewGuid(), name = "otherShtuka", price = 290, isExist = true, currency = Config.Currency.UAH };
    static Shop anotherShtuka = new Shop() { ID = Guid.NewGuid(), name = "anotherShtuka", price = 330, isExist = true, currency = Config.Currency.UAH };
    static Shop totallyAnotherShtuka = new Shop() { ID = Guid.NewGuid(), name = "totallyAnotherShtuka", price = 120, isExist = true, currency = Config.Currency.UAH };
    static Shop differentShtuka = new Shop() { ID = Guid.NewGuid(), name = "differentShtuka", price = 900, isExist = false, currency = Config.Currency.UAH };
    static Shop completelyDifferentShtuka = new Shop() { ID = Guid.NewGuid(), name = "completelyDifferentShtuka", price = 879, isExist = true, currency = Config.Currency.UAH };
    static Shop overpricedShtuka = new Shop() { ID = Guid.NewGuid(), name = "overpricedShtuka", price = 22, isExist = true, currency = Config.Currency.UAH };
    static Shop fancyShtuka = new Shop() { ID = Guid.NewGuid(), name = "modniyShtuka", price = 1300, isExist = true, currency = Config.Currency.UAH };
    static Shop uselessShtuka = new Shop() { ID = Guid.NewGuid(), name = "nuzhniyShtuka", price = 981, isExist = false, currency = Config.Currency.UAH };
    static Shop usefulShtuka = new Shop() { ID = Guid.NewGuid(), name = "nenuzhnyiShtuka", price = 130, isExist = true, currency = Config.Currency.UAH };
    static Shop completelyUselessShtuka = new Shop() { ID = Guid.NewGuid(), name = "usefulShtuka", price = 1400, isExist = true, currency = Config.Currency.UAH };
    static Shop Iphone = new Shop() { ID = Guid.NewGuid(), name = "Iphone", price = 999, isExist = true, currency = Config.Currency.UAH };


    public static Shop[] catalogue = new Shop[12] { shtuka, otherShtuka, anotherShtuka, totallyAnotherShtuka, differentShtuka, completelyDifferentShtuka, overpricedShtuka, fancyShtuka, uselessShtuka, usefulShtuka, completelyUselessShtuka, Iphone };

  }
}
