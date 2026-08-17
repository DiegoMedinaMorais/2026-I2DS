internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        Dictionary<int, string> cardapio = new Dictionary<int, string>();
        cardapio.Add(195, "X-Bacon");
        cardapio.Add(947, "Hambúrguer");
        cardapio.Add(826, "X-Tudo");
        cardapio.Add(043, "X-Chicken");
        foreach (var item in cardapio)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
        Console.WriteLine();
    }
}