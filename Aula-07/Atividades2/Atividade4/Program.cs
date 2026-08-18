internal class Program
{
    private static void Main(string[] args)
    {
        Queue<string> fila = new Queue<string>();
        fila.Enqueue("Anny");
        fila.Enqueue("Diego");
        fila.Enqueue("Daniel");
        fila.Enqueue("Murilo");
        fila.Enqueue("Jhonny");

        Console.WriteLine();
        Console.WriteLine("Fila inicial:");
        Console.WriteLine();

        foreach (var item in fila)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("Removendo as 2 primeiras pessoas");
        fila.Dequeue();
        fila.Dequeue();
        Console.WriteLine();
        Console.WriteLine("Fila final:");
        Console.WriteLine();

        foreach (var item in fila)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}