using Serializacao.Models;
using Newtonsoft.Json; // Esse pacote transforma  a informação em formato json para que possa ser usado em outro projeto caso necessário


Vendas v1 = new Vendas(1, "Material de escritório", 25.00M, DateTime.Now);
Vendas v2 = new Vendas(2, "Licença de Software", 110.00M, DateTime.UtcNow);

string conteudoArquivo = File.ReadAllText("Files/exemplo3.json");

List<Vendas> listaDeVendas = new List<Vendas>();

List<Desserializar> todasVendas = JsonConvert.DeserializeObject<List<Desserializar>>(conteudoArquivo);

listaDeVendas.Add(v1);
listaDeVendas.Add(v2);

string Serializacao = JsonConvert.SerializeObject(v1, Formatting.Indented);

string ListaDeSerializacao = JsonConvert.SerializeObject(listaDeVendas, Formatting.Indented);

File.WriteAllText("Files/exemplo.json", Serializacao); //Esse metodo cria um arquivo na pasta informada

File.WriteAllText("Files/exemplo3.json", ListaDeSerializacao);

Console.WriteLine(ListaDeSerializacao);

foreach (Desserializar venda in todasVendas)
{
  Console.WriteLine($"ID: {venda.Id} - Produto: {venda.Produto} - R${venda.Preco} - Data da Compra: {venda.DataVenda}");
}

