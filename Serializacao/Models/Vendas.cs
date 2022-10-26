using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serializacao.Models
{
  public class Vendas
  {
    public int Id { get; set; }
    public string Produto { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataVenda { get; set; }

    public Vendas(
      int Id,
      string Produto,
      decimal Preco,
      DateTime DataVenda
    )
    {
      this.Id = Id;
      this.Produto = Produto;
      this.Preco = Preco;
      this.DataVenda = DataVenda;
    }

  }
}