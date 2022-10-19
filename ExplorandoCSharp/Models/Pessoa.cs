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

    private string _Nome;
    private int _Idade;
    public string Nome
    {
      //Usando Boby expressions  
      get => _Nome.ToUpper();

      set
      {
        if (value == "")
        {
          throw new ArgumentException("O nome não pode ser vázio");
        }
        _Nome = value;
      }
    }
    public int Idade
    {
      get => _Idade;

      set
      {
        if (value < 0)
        {
          throw new ArgumentException("A idade não pode ser menor que 0");
        }

        _Idade = value;
      }
    }

    /// <summary>
    /// Apresenta o nome a idade da pessoa
    /// </summary>
    public void Apresentar()
    {
      Console.WriteLine($"Nome: {Nome} - Idade: {Idade}");
    }
  }
}