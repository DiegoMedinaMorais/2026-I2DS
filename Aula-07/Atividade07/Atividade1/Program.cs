internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        List<string> cidades = ["São Paulo", "Jáu", "Bauru", "Igaraçu do Tietê", "Barra Bonita"];
        foreach (var item in cidades)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}