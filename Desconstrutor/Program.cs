
using Desconstrutor.Models;


Pessoa p1 = new Pessoa("Adrian", 2);

(string nome, int idade) = p1;

Console.WriteLine($"{nome} - {idade}");