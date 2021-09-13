using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
  public class Shop
  {



    private static readonly Shop Shtuka = new Shop() { ID = Guid.NewGuid(), Name = "shtuka", price = 220, IsExist = true, Currency = Config.Currency.UAH };
    private static readonly Shop OtherShtuka = new Shop() { ID = Guid.NewGuid(), Name = "otherShtuka", price = 290, IsExist = true, Currency = Config.Currency.UAH };
    private static readonly Shop AnotherShtuka = new Shop() { ID = Guid.NewGuid(), Name = "anotherShtuka", price = 330, IsExist = true, Currency = Config.Currency.UAH };
    private static readonly Shop TotallyAnotherShtuka = new Shop() { ID = Guid.NewGuid(), Name = "totallyAnotherShtuka", price = 120, IsExist = true, Currency = Config.Currency.UAH };
    private static readonly Shop DifferentShtuka = new Shop() { ID = Guid.NewGuid(), Name = "differentShtuka", price = 900, IsExist = false, Currency = Config.Currency.UAH };
    private static readonly Shop CompletelyDifferentShtuka = new Shop() { ID = Guid.NewGuid(), Name = "completelyDifferentShtuka", price = 879, IsExist = true, Currency = Config.Currency.UAH };
    private static readonly Shop OverpricedShtuka = new Shop() { ID = Guid.NewGuid(), Name = "overpricedShtuka", price = 22, IsExist = true, Currency = Config.Currency.UAH };
    private static readonly Shop FancyShtuka = new Shop() { ID = Guid.NewGuid(), Name = "modniyShtuka", price = 1300, IsExist = true, Currency = Config.Currency.UAH };
    private static readonly Shop UselessShtuka = new Shop() { ID = Guid.NewGuid(), Name = "nuzhniyShtuka", price = 981, IsExist = false, Currency = Config.Currency.UAH };
    private static readonly Shop UsefulShtuka = new Shop() { ID = Guid.NewGuid(), Name = "nenuzhnyiShtuka", price = 130, IsExist = true, Currency = Config.Currency.UAH };
    private static readonly Shop CompletelyUselessShtuka = new Shop() { ID = Guid.NewGuid(), Name = "usefulShtuka", price = 1400, IsExist = true, Currency = Config.Currency.UAH };
    private static readonly Shop Iphone = new Shop() { ID = Guid.NewGuid(), Name = "Iphone", price = 999, IsExist = true, Currency = Config.Currency.UAH };
    private uint price;
    public static Shop[] Catalogue = new Shop[12] { Shtuka, OtherShtuka, AnotherShtuka, TotallyAnotherShtuka, DifferentShtuka, CompletelyDifferentShtuka, OverpricedShtuka, FancyShtuka, UselessShtuka, UsefulShtuka, CompletelyUselessShtuka, Iphone };


    Guid ID;

    public string Name { get; set; }

    public uint Price { get; set; }

    public bool IsExist { get; set; }

    public Config.Currency Currency { get; set; }





    public Shop()
    {
    }
    public Shop(Guid id, string name, uint price, bool isExist, Config.Currency currency)
    {
      ID = Guid.NewGuid();
      Name = this.Name;
      Price = this.Price;
      this.IsExist = true;
      this.Currency = this.Currency;
    }

  }
}
