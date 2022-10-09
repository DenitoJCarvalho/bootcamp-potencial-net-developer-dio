using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Common.Models
{
  //=> começo do escopo
  //=> Nas classes sempre usar PascalCase e para  uma boa leitura usar o mesmo nome do arquivo
  public class Pessoa
  {
    public string? Nome { get; set; } //=> propriedade, get = pegavalor, set = atribui valor
    public int Idade { get; set; } //=> propriedade, get = pegavalor, set = atribui valor
    public string? Sobrenome { get; set; } //=> nas propriedades sempre usar PascalCase
    public DateTime DataDeNascimento { get; set; }

    public void Apresentar() //=> método = ação,
    {
      Console.WriteLine(@$"
        Olá, meu nome é {Nome} {Sobrenome.ToUpper()}, 
        e tenho {Idade} anos e nasci em {DataDeNascimento}"
        );
    }
  }
  //=> fim do escopo
}