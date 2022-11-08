using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
  /*
      Exemplo de herança
      Nesse caso aluno herda propriedades e métodos da classe Pessoa
  */
  public class Aluno : Pessoa
  {
    public double Nota { get; set; }

    /// <summary>
    /// Apresenta o aluno e sua nota.
    /// </summary>
    public override void Apresentar()
    {
      //exemplo de polimorfismo
      Console.WriteLine($"Olá, meu nome é {Nome}, minha idade é {Idade} anos e sou aluno de nota {Nota}");
    }
  }
}