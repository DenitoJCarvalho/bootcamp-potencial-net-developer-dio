using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Common.Models
{
  public class Endereco
  {
    public string? Rua { get; set; }
    public uint Numero { get; set; }
    public string? Complemento { get; set; }
    public string? Bairro { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }

    public void EnderecoCompleto()
    {
      Console.WriteLine(@$"
            Moro na rua {Rua}, {Numero}, {Complemento}
            {Bairro}, {Cidade}, {Estado}
        ");
    }
  }
}