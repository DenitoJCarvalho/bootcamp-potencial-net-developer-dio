using ExplorandoCSharp.Models;
using System.Globalization;

Pessoa p1 = new Pessoa("Adrian", "D. de Carvalho");
Pessoa p2 = new Pessoa("Lívia", "D. de Carvalho");

Moedas moeda = new Moedas();
Datas data = new Datas();

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

moeda.ApresentarValorMonetario(20);
moeda.ApresentarValorMonetario(20, "es-US");
moeda.ApresentarValorMonetario(20, "es-Ar");

data.ApresentarData(DateTime.Parse("2022-10-10"));