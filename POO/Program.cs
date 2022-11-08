using System;

using POO.Models;

Pessoa p1 = new Pessoa();
ContaCorrente c1 = new ContaCorrente(12345, 238.48M);

p1.Nome = "Adrian";
p1.Idade = 2;

p1.Apresentar();
c1.Sacar(30.00M);

