internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        List<int> numeros = [-10, 45, 67, -2, 65, -26, 3, 29, -97, -48];
        Console.WriteLine("Lista de números:");
        Console.WriteLine();
        foreach (var item in numeros)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine("Lista de números onde cada valor positivo é filtrado e dobrado em 2:");
        Console.WriteLine();
        var listaFiltrada = numeros.Where(a => a > 0).Select(a => a*2);
        foreach (var item in listaFiltrada)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}