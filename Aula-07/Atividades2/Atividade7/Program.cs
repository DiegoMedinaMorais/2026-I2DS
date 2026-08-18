internal class Program
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

    }
    private static void Main(string[] args)
    {
        Console.WriteLine();
        List<Produto> produtos = new List<Produto>();
        Produto produto1 = new Produto { Id = 624, Nome = "Mouse", Preco = 70.99 };
        Produto produto2 = new Produto { Id = 727, Nome = "Almofada", Preco = 43.20 };
        Produto produto3 = new Produto { Id = 019, Nome = "Perfume", Preco = 135.99 };
        Produto produto4 = new Produto { Id = 095, Nome = "Monitor", Preco = 120.99 };
        Produto produto5 = new Produto { Id = 157, Nome = "Batata", Preco = 6.30 };
        produtos.Add(produto1);
        produtos.Add(produto2);
        produtos.Add(produto3);
        produtos.Add(produto4);
        produtos.Add(produto5);

        var produtosCaro = produtos.Where(prod => prod.Preco >= 50).ToList();

        Console.WriteLine("Lista de produtos:");
        Console.WriteLine();
        foreach (var item in produtos)
        {
            Console.WriteLine($"Nome: {item.Nome} - Id: {item.Id} - Preço: {item.Preco}");
        }
        Console.WriteLine();
        Console.WriteLine("Lista de produtos com preço maior que R$50.00:");
        Console.WriteLine();
        foreach (var item in produtosCaro)
        {
            Console.WriteLine($"Nome: {item.Nome} - Id: {item.Id} - Preço: {item.Preco}");
        }
        Console.WriteLine();
    }
}