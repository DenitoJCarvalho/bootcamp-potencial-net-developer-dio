using System.IO;
using System.Linq;

class Dio
{
  static void Main(string[] args)
  {
    int qt = int.Parse(Console.ReadLine());

    for (var i = 0; i < qt; i++)
    {

      string[] v = Console.ReadLine().Split(" ");
      string a = v[0];
      string b = v[1];

      if (!a.EndsWith(b))
      {
        Console.WriteLine("não encaixa");
      }
      else if (a.EndsWith(b))
      {
        Console.WriteLine("encaixa");
      }
      else
      {
        Console.WriteLine("não encaixa");
      }
    }
  }
}