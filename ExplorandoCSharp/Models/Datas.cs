using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoCSharp.Models
{
  public class Datas
  {
    DateTime data { get; set; }

    /// <summary>
    /// retorna a data informada
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public DateTime ApresentarData(DateTime data)
    {
      Console.WriteLine($"{data}");
      return data;
    }
  }
}