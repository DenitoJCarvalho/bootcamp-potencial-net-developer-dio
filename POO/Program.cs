using System;

using POO.Models;

Pessoa p1 = new Pessoa();
ContaCorrente c1 = new ContaCorrente(12345, 238.48M);

p1.Nome = "Adrian";
p1.Idade = 2;

p1.Apresentar();
c1.Sacar(30.00M);

Aluno aluno = new Aluno();
aluno.Nome = "Lívia";
aluno.Idade = 6;
aluno.Nota = 7.5;

aluno.Apresentar();

Professor professor = new Professor();
professor.Nome = "Jessica";
professor.Idade = 31;
professor.Materia = "Artes";
professor.Salario = 3200.34M;

professor.Apresentar();

