using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module2HW2
{
  public sealed class Cart
  {
    static Cart()
    {
    }

    private Cart()
    {

    }

    public static Cart Instance
    {
      get
      {
        return Instance;
      }
    }


  }

}