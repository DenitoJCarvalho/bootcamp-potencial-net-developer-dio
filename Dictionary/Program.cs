Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("RS", "Rio Grande do Sul");
estados.Add("SC", "Santa Catarina");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

foreach (var item in estados)
{
  Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}


Console.WriteLine($"Chave removida - {estados.Remove("BA")}");