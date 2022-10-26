using MetodoDeExtensao.Models;

int numero = Convert.ToInt32(Console.ReadLine());
bool par = false;

par = numero.isPar();

string msg = $"O número {numero} é {(par ? "par" : "ímpar")}";

Console.WriteLine(msg);

