internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, double> telefones = new Dictionary<string, double>();

        telefones.Add("John", 8581032494);
        telefones.Add("Maria", 9283967294);
        telefones.Add("Zeca", 8468475827);
        telefones.Add("Bob", 9461850721);

        Console.WriteLine();
        foreach (var item in telefones)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
        Console.WriteLine();

        Console.WriteLine("Novo elemento cadastrado");
        
        telefones.Add("Simon", 9475746598);
        Console.WriteLine();
        foreach (var item in telefones)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
        Console.WriteLine();

        Console.WriteLine("Pesquisando elemento pelo nome John");
        Console.WriteLine();
        double termo;
        bool chaveExiste = telefones.TryGetValue("John", out termo);
        if (chaveExiste)
        {
            Console.WriteLine($"O número foi encontrado: {termo}");
        }
        else
        {
            Console.WriteLine("O número não foi encontrado.");
        }

        Console.WriteLine();
        Console.WriteLine("Editando telefone de Bob");
        telefones["Bob"] = 0495937594;
        Console.WriteLine();
        foreach (var item in telefones)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
        Console.WriteLine();
        Console.WriteLine("Removendo Maria");
        telefones.Remove("Maria");
        Console.WriteLine();
        foreach (var item in telefones)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
        Console.WriteLine();
    }
}