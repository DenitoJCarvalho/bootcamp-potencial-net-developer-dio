using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace ExplorandoCSharp.Models
{
  public class Moedas
  {
    decimal valorMonetatio { get; set; }
    string cultura { get; set; }

    /// <summary>
    /// Converte o valor para a moeda local
    /// </summary>
    public void ApresentarValorMonetario()
    {
      Console.WriteLine($"{valorMonetatio.ToString("C")}");
    }

    /// <summary>
    /// Converte valor para a moeda local passando um parâmetro
    /// </summary>
    /// <param name="valorMonetatio"></param>
    public void ApresentarValorMonetario(decimal valorMonetatio)
    {
      Console.WriteLine($"{valorMonetatio.ToString("C")}");
      Console.WriteLine($"{valorMonetatio.ToString("C1")}");
      Console.WriteLine($"{valorMonetatio.ToString("C2")}");
    }

    /// <summary>
    /// Converte valor monetário para a moeda local passando um parâmetro e ser passar a cultura altera para geolocalização do sistema informado
    /// </summary>
    /// <param name="valorMonetatio"></param>
    /// <param name="cultura"></param>
    public void ApresentarValorMonetario(decimal valorMonetatio, string cultura)
    {
      CultureInfo.DefaultThreadCurrentCulture = new CultureInfo(cultura);
      Console.WriteLine($"{valorMonetatio.ToString("C")}");
    }
  }
}