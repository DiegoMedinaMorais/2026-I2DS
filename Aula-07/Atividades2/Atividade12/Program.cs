internal class Program
{
    public class Venda
    {
        public string Produto { get; set; }
        public string Categoria { get; set; }
        public int Valor { get; set; }
    }
    private static void Main(string[] args)
    {
        List<Venda> vendas = new List<Venda>();
        Venda venda1 = new Venda { Produto = "Mouse", Categoria = "Eletrônico", Valor = 73 };
        Venda venda2 = new Venda { Produto = "Monitor", Categoria = "Eletrônico", Valor = 120 };
        Venda venda3 = new Venda { Produto = "Batata", Categoria = "Alimento", Valor = 5 };
        Venda venda4 = new Venda { Produto = "Cenoura", Categoria = "Alimento", Valor = 6 };
        Venda venda5 = new Venda { Produto = "Melancia", Categoria = "Alimento", Valor = 10 };
        Venda venda6 = new Venda { Produto = "Sofá", Categoria = "Movel", Valor = 1267 };
        Venda venda7 = new Venda { Produto = "Mesa", Categoria = "Movel", Valor = 854 };
        Venda venda8 = new Venda { Produto = "Mouse", Categoria = "Movel", Valor = 242 };
        vendas.Add(venda1);
        vendas.Add(venda2);
        vendas.Add(venda3);
        vendas.Add(venda4);
        vendas.Add(venda5);
        vendas.Add(venda6);
        vendas.Add(venda7);
        vendas.Add(venda8);

        int valorVenda = 0;

        var vendasGrupos = vendas.GroupBy(a => a.Categoria);

        Console.WriteLine();
        foreach (var grupo in vendasGrupos)
        {
            Console.WriteLine($"Categoria {grupo.Key}:");
            Console.WriteLine();
            var soma = grupo.Sum(a => a.Valor);
            if (soma > valorVenda)
            {
                valorVenda = soma;
            }
            foreach (var item in grupo)
            {
                Console.WriteLine($"Produto: {item.Produto} - Categoria: {item.Categoria} - Valor: {item.Valor}");
            }
            Console.WriteLine();
            Console.WriteLine($"Total de vendas da categoria: {soma}");
            Console.WriteLine();
            Console.WriteLine("-----");
            Console.WriteLine();
        }

        var categoriaVencedora = vendasGrupos.OrderByDescending(a => a.Sum(b => b.Valor)).First().Key;
        Console.WriteLine($"A categoria com maior faturamento é: {categoriaVencedora}, com total de vendas de: {valorVenda}");
        Console.WriteLine();
    }
}