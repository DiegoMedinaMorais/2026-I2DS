using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] produtos = new string[100];
        double[] precos = new double[100];

        SelecionarMenu(produtos, precos);
    }

    public static void SelecionarMenu(string[] produtos, double[] precos)
    {
        Console.WriteLine("\nMENU\n\n1-Cadastrar novo produto\n2-Listar produtos cadastrados\n3-Pesquisar produto pelo nome\n");

        Console.Write("Digite o número do menu: ");
        int menuSelecionado = int.Parse(Console.ReadLine());

        IrAoMenu(menuSelecionado, produtos, precos);
    }

    public static void IrAoMenu(int menuSelecionado, string[] produtos, double[] precos)
    {
        switch (menuSelecionado)
        {
            case 1:
                Cadastrar(produtos, precos);
                break;
            case 2:
                Listar(produtos, precos);
                break;
            case 3:
                Pesquisar(produtos, precos);
                break;

            default:
                Console.WriteLine("\nNúmero selecionado não corresponde a uma função existente.\n");
                break;
        }
    }

    public static void Cadastrar(string[] produtos, double[] precos)
    {
        Console.WriteLine("\nCADASTRO\n");
        int i = 0;
        foreach (string p in produtos)
        {
            if (p != null) { i++; }
        }
        Console.Write("Digite o nome do novo produto: ");
        string produto = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("Digite o preço do novo produto: ");
        int preco = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Produto " + produto + " cadastrado com preço " + preco + ".");
        produtos[i] = produto;
        precos[i] = preco;

        SelecionarMenu(produtos, precos);
    }

    public static void Listar(string[] produtos, double[] precos)
    {
        Console.WriteLine("\nLISTA\n");

        for (int i = 0; i < produtos.Length; i++)
        {
            if (produtos[i] != null)
            {
                Console.WriteLine(produtos[i]);
                Console.WriteLine(precos[i]);
            }
        }

        SelecionarMenu(produtos, precos);
    }

    public static void Pesquisar(string[] produtos, double[] precos)
    {
        Console.Write("\nDigite o nome do produto que quer pesquisar: ");
        string produto = Console.ReadLine();

        int index = -1;

        foreach (string p in produtos)
        {
            index++;
            if (p == produto)
            {
                break;
            }
        }

        Console.WriteLine("");

        Console.WriteLine("Produto: " + produtos[index]);
        Console.WriteLine("Preço: "+ precos[index]);

        SelecionarMenu(produtos, precos);
    }
}