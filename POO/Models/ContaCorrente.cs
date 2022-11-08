using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
  //Exemplo de encapsulamento
  public class ContaCorrente
  {
    public int NumeroConta { get; set; }
    private decimal Saldo { get; set; }

    public ContaCorrente(int NumeroConta, decimal Saldo)
    {
      this.NumeroConta = NumeroConta;
      this.Saldo = Saldo;
    }

    public void Sacar(decimal valor)
    {
      Saldo -= valor;
      Console.WriteLine(@$"
        O valor sacado foi de R${valor}
        Saldo disponível no momento é R${Saldo}
      ");
    }
  }
}