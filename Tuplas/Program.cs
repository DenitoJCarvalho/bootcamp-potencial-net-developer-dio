using Tuplas.Models;

(int ID, string Nome, string Profissao) tupla = (1, "Adrian", "Programador de Robótica");

ValueTuple<int, string, string> employees = (1, "Adrian", "Programador de Robótica");

var alunos = Tuple.Create(1, "Adrian", "Programador de Robótica");


Console.WriteLine(@$"
  ID: {tupla.ID}
  Nome: {tupla.Nome}
  Profissão: {tupla.Profissao}
");

Console.WriteLine(@$"
  ID: {employees.Item1}
  Nome: {employees.Item2}
  Profissão: {employees.Item3}
");

Console.WriteLine(@$"
  ID: {alunos.Item1}
  Nome: {alunos.Item2}
  Profissão: {alunos.Item3}
");

LeituraArquivo file = new LeituraArquivo();

Console.WriteLine(file.LeituraDeArquivo("Arquivos/adrianTeste.txt"));