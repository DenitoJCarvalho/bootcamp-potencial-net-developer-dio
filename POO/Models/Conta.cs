using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
  public abstract class Conta
  {
    protected decimal saldo;

    public abstract void Creditar(decimal valor);

    /// <summary>
    /// Exibe o saldo da conta.
    /// </summary>
    public void ExibirSaldo()
    {
      Console.WriteLine($"O seu saldo é R${saldo}");
    }
  }
}