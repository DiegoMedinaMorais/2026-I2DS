internal class Program
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Preco { get; set; }
        public string Categoria { get; set; }
    }
    private static void Main(string[] args)
    {
        Produto produto1 = new Produto { Nome = "Mouse", Preco = 20, Categoria = "Tecnologia" };
        Produto produto2 = new Produto { Nome = "Monitor", Preco = 40, Categoria = "Tecnologia" };
        Produto produto3 = new Produto { Nome = "Teclado", Preco = 30, Categoria = "Tecnologia" };
        Produto produto4 = new Produto { Nome = "TV", Preco = 60, Categoria = "Tecnologia" };
        Produto produto5 = new Produto { Nome = "Cama", Preco = 50, Categoria = "Dormir" };
        Produto produto6 = new Produto { Nome = "Travesseiro", Preco = 20, Categoria = "Dormir" };
        Produto produto7 = new Produto { Nome = "Cobertor", Preco = 20, Categoria = "Dormir" };
        Produto produto8 = new Produto { Nome = "Lagarto", Preco = 45, Categoria = "Pet" };
        Produto produto9 = new Produto { Nome = "Cachorro", Preco = 20, Categoria = "Pet" };
        Produto produto10 = new Produto { Nome = "Pássaro", Preco = 15, Categoria = "Pet" };

        List<Produto> produtos = new List<Produto>();

        produtos.Add(produto1);
        produtos.Add(produto2);
        produtos.Add(produto3);
        produtos.Add(produto4);
        produtos.Add(produto5);
        produtos.Add(produto6);
        produtos.Add(produto7);
        produtos.Add(produto8);
        produtos.Add(produto9);
        produtos.Add(produto10);

        Console.WriteLine();
        Console.Write("Digite um preço mínimo: ");
        int precoMin = int.Parse(Console.ReadLine());
        Console.WriteLine();

        var produtosPrecoMin = produtos.Where(p => p.Preco >= precoMin).ToList();
        foreach (var item in produtosPrecoMin)
        {
            Console.WriteLine($"Nome: {item.Nome} - Preço: {item.Preco} - Categoria: {item.Categoria}");
        }

        Console.WriteLine();
    }
}