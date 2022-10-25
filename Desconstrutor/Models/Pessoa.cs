using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desconstrutor.Models
{
  public class Pessoa
  {
    private string Name { get; set; }
    private int Age { get; set; }

    public Pessoa(string Name, int Age)
    {
      this.Name = Name;
      this.Age = Age;
    }

    /// <summary>
    /// No método descontrutor ela faz papel inverso ao do construtor. O parâmetro recebe recebe a propriedade como variável
    /// </summary>
    /// <param name="nome"></param>
    /// <param name="idade"></param>
    public void Deconstruct(out string nome, out int idade)
    {
      nome = Name;
      idade = Age;
    }
  }
}