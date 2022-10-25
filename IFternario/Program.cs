
int numero = Convert.ToInt32(Console.ReadLine());

bool isPar = false;

isPar = numero % 2 == 0;

Console.WriteLine($"O número {numero} é {(isPar ? "par" : "impar")}");

