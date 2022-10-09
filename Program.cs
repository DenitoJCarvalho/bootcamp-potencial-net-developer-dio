// See https://aka.ms/new-console-template for more information
using System;

using bootcamp_potencial_net_developer_dio.Models;

class Program
{
  static void Main(string[] args)
  {
    Pessoa pessoa1 = new Pessoa();
    Endereco endereco = new Endereco();
    Casting conversor = new Casting();

    pessoa1.Nome = "Lívia";
    pessoa1.Idade = 6;
    pessoa1.Sobrenome = "Deni de Carvalho";
    pessoa1.DataDeNascimento = DateTime.Now;

    endereco.Rua = "Delicia";
    endereco.Numero = 14;
    endereco.Complemento = "Fundos";
    endereco.Bairro = "Panetone";
    endereco.Cidade = "Itu";
    endereco.Estado = "SP";

    pessoa1.Apresentar();
    endereco.EnderecoCompleto();

    conversor.Conversor("10");
    conversor.Conversor("21");
  }
}
