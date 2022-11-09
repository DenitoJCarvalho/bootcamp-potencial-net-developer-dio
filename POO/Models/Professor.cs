using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
  /*
    Exemplo de herança
    Nesse caso aluno herda propriedades e métodos da classe Pessoa

    A palavra reservada sealed indica que essa classe não pode ser herdada.
*/
  public sealed class Professor : Pessoa
  {
    public decimal Salario { get; set; }
    public string Materia { get; set; }

    public Professor(string Nome) : base(Nome) { }

    /// <summary>
    /// Esse método não podeser subescrito, pois foi selado.
    /// </summary>
    public override sealed void Apresentar()
    {
      //exemplo de polimorfismo
      Console.WriteLine($"Olá, sou a professora {Nome}, tenho {Idade} anos. vou dar aula de {Materia}. Meu salário é de R${Salario}");
    }
  }
}