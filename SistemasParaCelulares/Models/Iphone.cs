using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasParaCelulares.Models
{
  public class Iphone : Smartphone
  {
    /// <summary>
    /// Método construtor
    /// </summary>
    /// <param name="Numero"></param>
    /// <param name="Modelo"></param>
    /// <param name="IMEI"></param>
    /// <param name="Memoria"></param>
    public Iphone(
        string Numero,
        string Modelo,
        string IMEI,
        int Memoria
    ) : base(Numero, Modelo, IMEI, Memoria) { }

    #region Instalar aplicativo
    public override void InstalarAplicativo(string Nome) { }
    #endregion
  }
}