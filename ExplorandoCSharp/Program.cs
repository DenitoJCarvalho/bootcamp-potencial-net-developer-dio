using ExplorandoCSharp.Models;

Pessoa p1 = new Pessoa("Adrian", "D. de Carvalho");
Pessoa p2 = new Pessoa("Lívia", "D. de Carvalho");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();