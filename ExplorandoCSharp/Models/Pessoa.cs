using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoCSharp.Models
{
  public class Pessoa
  {
    /// <summary>
    /// As caracteristicas das propriedades são get e set, ou seja, pegar e setar.
    /// </summary>
    public string Nome { get; set; }
    public int Idade { get; set; }

    /// <summary>
    /// Apresenta o nome a idade da pessoa
    /// </summary>
    public void Apresentar()
    {
      Console.WriteLine($"Nome: {Nome} - Idade: {Idade}");
    }
  }
}