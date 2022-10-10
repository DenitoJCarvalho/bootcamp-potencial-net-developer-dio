// Dado um número inteiro (n), retorne a diferença entre o produto de seus digitos e a soma de seus digitos
using System;

class Dio
{
  static void Main(string[] args)
  {
    try
    {
      int n = int.Parse(Console.ReadLine());
      int p = 1, s = 0;

      while (n > 0)
      {
        int l = n % 10;

        p *= l;
        s += l;
        n /= 10;
      }

      Console.WriteLine(p - s);

    }
    catch (Exception error)
    {
      Console.WriteLine($"Erro: {error.Message}");
    }
  }

}