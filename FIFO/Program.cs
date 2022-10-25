
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(5);
fila.Enqueue(8);
fila.Enqueue(11);

foreach (int item in fila)
{
  Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");


foreach (int item in fila)
{
  Console.WriteLine(item);
}