using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using POO.Interfaces;

namespace POO.Models
{
  public class CalculadoraComum : ICalculadora
  {
    public int Numero1 { get; set; }
    public int Numero2 { get; set; }

    public int Somar(int Numero1, int Numero2)
    {
      return Numero1 + Numero2;
    }

    public int Subtrair(int Numero1, int Numero2)
    {
      return Numero1 - Numero2;
    }

    public int Multiplicar(int Numero1, int Numero2)
    {
      return Numero1 * Numero2;
    }
  }
}