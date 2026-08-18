internal class Program
{
    private static void Main(string[] args)
    {
        Queue<string> fila = new Queue<string>();
        fila.Enqueue("João");
        fila.Enqueue("Maria");
        fila.Enqueue("Carlos");
        fila.Enqueue("Ana");
        fila.Enqueue("Pedro");

        Console.WriteLine();
        foreach (var item in fila)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        string pessoaSai = fila.Dequeue();
        Console.WriteLine($"Cliente {pessoaSai} saiu da fila (foi atendido).");
        Console.WriteLine();
        foreach (var item in fila)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine("Bob entra na fila");
        fila.Enqueue("Bob");
        Console.WriteLine();
        foreach (var item in fila)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}