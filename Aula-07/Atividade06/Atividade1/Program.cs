internal class Program
{
    private static void Main(string[] args)
    {
        // add 5 frutas list
        // exibir frutas 
        // solicitar nova
        // add nova
        // mostrar novamente

        Console.WriteLine();

        List<string> frutas = new List<string>();

        frutas.Add("Mamão");
        frutas.Add("Kiwi");
        frutas.Add("Maça");
        frutas.Add("Banana");
        frutas.Add("Caju");

        foreach (var item in frutas)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("Digite uma fruta para adicionar:");
        string frutaNova = Console.ReadLine();
        Console.WriteLine();
        frutas.Add(frutaNova);
        foreach (var item in frutas)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}