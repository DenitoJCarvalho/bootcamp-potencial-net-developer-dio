using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemDeHotel.Models
{
  public class Reserva
  {
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva(
        int DiasReservados
    )
    {
      this.DiasReservados = DiasReservados;
    }

    /// <summary>
    /// Para cadastrar os hospedes passe uma lista do tipo pessoa
    /// Que irá verificar a se a capacidade e menor que a quantidade de hospedes. Se verdadeiro retorna uma exceção.
    /// </summary>
    /// <param name="hospedes"></param>
    /// <param name="suite"></param>
    /// <exception cref="Exception"></exception>
    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
      if (hospedes.Count <= Suite.Capacidade)
      {
        Hospedes = hospedes;
      }
      else
      {
        throw new Exception("O número de hospedes é maior que a capacidade da suite.");
      }
    }

    /// <summary>
    /// Para cadastrar uma suite passe uma suite do tipo suite
    /// </summary>
    /// <param name="suite"></param>
    public void CadastrarSuite(Suite suite)
    {
      Suite = suite;
    }

    /// <summary>
    /// Retorna quantidade de hospedes.
    /// </summary>
    /// <returns></returns>
    public int ObterQuantidadeHospedes()
    {
      return Hospedes.Count();
    }

    /// <summary>
    /// Calcula o valor da diária. Se aos dias reservados for maior ou igual a 10 os hospedes recebem 10% de desconto.
    /// </summary>
    /// <returns></returns>
    public decimal CalcularValorDiaria()
    {
      decimal valor = 0;

      valor = Suite.ValorDiaria * DiasReservados;

      if (DiasReservados >= 10)
      {
        valor = valor + (valor * 0.10M);
      }

      return valor;
    }
  }
}