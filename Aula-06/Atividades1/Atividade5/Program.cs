internal class Program
{
    private static void Main(string[] args)
    {
        Stack<string> navegacao = new Stack<string>();

        navegacao.Push("google.com");
        navegacao.Push("youtube.com");
        navegacao.Push("github.com");
        navegacao.Push("microsoft.com");

        Console.WriteLine();
        foreach (var item in navegacao)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine();

        Console.WriteLine($"Página atual: {navegacao.FirstOrDefault()}");
        Console.WriteLine();
        Console.WriteLine("Voltando para pagina anterior");
        Console.WriteLine();
        navegacao.Pop();
        foreach (var item in navegacao)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine($"Página atual: {navegacao.FirstOrDefault()}");
        Console.WriteLine();
        Console.WriteLine("Adicionando página instagram.com");
        navegacao.Push("instagram.com");
        Console.WriteLine();
        foreach (var item in navegacao)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}