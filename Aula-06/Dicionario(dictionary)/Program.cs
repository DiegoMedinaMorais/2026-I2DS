internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("=== TRABALHANDO COM DICIONÁRIOS ===");

        // 1 - criar um dicionário

        // sintaxe: Dictonary<chave, valor>
        //                     key,  value

        Dictionary<string, string> dicionario = new Dictionary<string, string>();

        // 2 - adicionar elementos no dicionario

        dicionario.Add("Casa", "Construção destinada à moradia.");
        dicionario.Add("Livro", "Conjunto de páginas encadernadas contendo textos, imagens ou informações.");
        dicionario.Add("Amizade", "Relação de afeto, confiança e companheirismo entre pessoas.");
        dicionario.Add("Escola", "Instituição destinada ao ensino e à educação de crianças, jovens ou adultos.");

        // 3 - percorrer todos os elementos de um dicionário

        Console.WriteLine();

        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 4 - alterar um elemento do dicionário

        dicionario["Casa"] = "Construção destinada à moradia definitiva ou temporária.";
        Console.WriteLine();

        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 5 - verificar se uma chave (key) existe dentro do dicionário

        Console.WriteLine();

        string termo;
        bool chaveExiste = dicionario.TryGetValue("Amizade", out termo);
        if (chaveExiste)
        {
            Console.WriteLine($"A palavra foi encontrada: {termo}");
        }
        else
        {
            Console.WriteLine("A palavra não foi encontrada no dicionário");
        }

        // 6 - excluir um elemento do dicionário

        dicionario.Remove("Casa");
        Console.WriteLine();

        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 7 - ordenar um dicionário por chave

        // dicionario.OrderBy(i => i.Key); não ordena dicionário mas sim cria uma cópia dele ordenado.

        var dicionarioOrdenado = dicionario.OrderBy(i => i.Key); 
        Console.WriteLine();

        foreach (var item in dicionarioOrdenado)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        Console.WriteLine();
    }
}