using System;

using POO.Models;
using POO.Interfaces;

Pessoa p1 = new Pessoa("Dennis");
ContaCorrente c1 = new ContaCorrente(12345, 238.48M);

p1.Nome = "Adrian";
p1.Idade = 2;

p1.Apresentar();
c1.Sacar(30.00M);

Aluno aluno = new Aluno("Lívia");
aluno.Idade = 6;
aluno.Nota = 7.5;

aluno.Apresentar();

Professor professor = new Professor("Jéssica");
professor.Idade = 31;
professor.Materia = "Artes";
professor.Salario = 3200.34M;

professor.Apresentar();

Corrente cc = new Corrente();
cc.Creditar(500);
cc.ExibirSaldo();

Computador computer = new Computador();

ICalculadora calcular = new CalculadoraComum();
Console.WriteLine($"A soma dos valores é: {calcular.Somar(120, 20)}");
Console.WriteLine($"A subtração dos valores é: {calcular.Subtrair(120, 20)}");
Console.WriteLine($"A multtiplicação dos valores é: {calcular.Multiplicar(120, 20)}");
Console.WriteLine($"A divisão dos valores é: {calcular.Dividir(120, 20)}");

