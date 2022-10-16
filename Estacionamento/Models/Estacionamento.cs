using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
  public class Estacionamento
  {
    private decimal precoInicial { get; set; }
    private decimal precoPorHora { get; set; }
    private List<string> veiculos { get; set; }

    /// <summary>
    ///   Recebe uma placa digitada pelo usuário e guarda na variável veículos
    /// </summary>
    public void AdicionarVeiculo() { }

    /// <summary>
    ///   Verificar se um determnado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento
    ///   Calculo = precoInicial * precoPorHora
    /// </summary>
    public void RemoverVeiculo() { }

    /// <summary>
    ///   Lista todos os veículos presentes atualmente no estacionamento
    ///   Caso não haja veículos estacionados.
    /// </summary>
    public void ListarVeiculos() { }
  }
}