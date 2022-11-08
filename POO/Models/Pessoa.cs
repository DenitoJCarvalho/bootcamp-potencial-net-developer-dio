using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
  public class Pessoa
  {
    //Exemplo de Abstração
    public string Nome { get; set; }
    public int Idade { get; set; }

    /// <summary>
    /// Apresenta o nome da pessoa e sua idade.
    /// </summary>
    public void Apresentar()
    {
      Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
    }
  }
}