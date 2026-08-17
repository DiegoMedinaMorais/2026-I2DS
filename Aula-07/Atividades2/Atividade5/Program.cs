internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        Stack<string> historico = new Stack<string>();
        historico.Push("Digitar");
        historico.Push("Colar");
        historico.Push("Negrito");
        historico.Push("Apagar");

        string removido1 = historico.Pop();
        Console.WriteLine($"Item removido: {removido1}");
        Console.WriteLine();
        string removido2 = historico.Pop();
        Console.WriteLine($"Item removido: {removido2}");
        Console.WriteLine();
    }
}