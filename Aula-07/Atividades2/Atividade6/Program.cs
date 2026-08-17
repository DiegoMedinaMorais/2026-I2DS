internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        Func<int, int, int> Calcular = (a, b) => (a * b);
        Console.WriteLine($"Calculando 12 x 5: {Calcular(12, 5)}");
        Console.WriteLine($"Calculando 8 x 9: {Calcular(8, 9)}");
        Console.WriteLine($"Calculando 24 x 7: {Calcular(24, 7)}");
        Console.WriteLine();
    }

}