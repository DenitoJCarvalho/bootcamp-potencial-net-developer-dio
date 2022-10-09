using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Common.Models
{
  public class Casting
  {
    public void Conversor(string value)
    {
      Console.WriteLine(Convert.ToInt32(value));
      Console.WriteLine(Convert.ToDecimal(value));
      Console.WriteLine(long.Parse(value));
      Console.WriteLine(short.Parse(value));
    }
  }
}