
Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(5);
pilha.Push(6);
pilha.Push(7);
pilha.Push(12);

foreach (int item in pilha)
{
  Console.WriteLine(item);
}

pilha.Pop();
pilha.Push(100);

Console.WriteLine($"Removendo o elemento do topo {pilha.Pop()}");

foreach (int item in pilha)
{
  Console.WriteLine(item);
}

