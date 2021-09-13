using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
  public static class Config
  {
    public static readonly int CartSize = 10;
    public static readonly int CatalogueSize = 12;
    public static string clientName = "Vasyl";
    public static string clientEmail = "totallynotacop@gmail.com";
    public static string clientPhone = "+3809726552655";

    public enum Currency
    {
      USD,
      UAH,
      EUR
    }
  }
}
