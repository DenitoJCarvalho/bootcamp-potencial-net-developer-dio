using System.Text;

using HospedagemDeHotel.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(Nome: "Adrian");
Pessoa p2 = new Pessoa(Nome: "Lili");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(TipoSuite: "Premium", Capacidade: 5, ValorDiaria: 72.90M);

Reserva reserva = new Reserva(DiasReservados: 10);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria().ToString("C2")}");
