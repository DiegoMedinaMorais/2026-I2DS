internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        List<int> valores = [15,84,58,64,95];
        Console.WriteLine("Lista inicial:");
        Console.WriteLine();
        foreach (var item in valores)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine("Inserindo valor 100 na posição 2");
        Console.WriteLine();
        valores.Insert(2, 100);
        Console.WriteLine("Removendo elemento que está na última posição");
        Console.WriteLine();
        valores.RemoveAt(5);
        Console.WriteLine("Lista final:");
        Console.WriteLine();
        foreach (var item in valores)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}