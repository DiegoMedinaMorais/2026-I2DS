internal class Program
{
    public class Colaborador
    {
        public string? Nome { get; set; }
        public double Salario { get; set; }
        public DateOnly DataRegistro { get; set; }
    }
    private static void Main(string[] args)
    {
        Colaborador colab2 = new Colaborador { Nome = "John", Salario = 1740.00, DataRegistro = new DateOnly(2026, 03, 29) };
        Colaborador colab1 = new Colaborador { Nome = "Ana", Salario = 4050.00, DataRegistro = new DateOnly(2019, 01, 10) };
        Colaborador colab3 = new Colaborador { Nome = "Paulo", Salario = 2250.00, DataRegistro = new DateOnly(2025, 12, 07) };
        Colaborador colab4 = new Colaborador { Nome = "Maria", Salario = 1290.00, DataRegistro = new DateOnly(2022, 07, 06) };
        Colaborador colab5 = new Colaborador { Nome = "Zeca", Salario = 7680.00, DataRegistro = new DateOnly(2007, 10, 14) };

        // criar uma lista de colaboradores
        List<Colaborador> listaColab = new List<Colaborador>();
        listaColab.Add(colab1);
        listaColab.Add(colab2);
        listaColab.Add(colab3);
        listaColab.Add(colab4);
        listaColab.Add(colab5);

        Console.WriteLine();
        Console.WriteLine("=== LISTA DE COLABORADORES ===");
        ImprimirLista(listaColab);

        Console.WriteLine("\n=== LISTA ORDENADA POR NOME (crescente) ===");
        var listaOrdenadaNome = listaColab.OrderBy(colab => colab.Nome).ToList();
        ImprimirLista(listaOrdenadaNome);

        Console.WriteLine("\n=== LISTA ORDENADA POR NOME (decrescente) ===");
        var listaNomeInversa = listaColab.OrderByDescending(colab => colab.Nome).ToList();
        ImprimirLista(listaNomeInversa);

        Console.WriteLine("\n=== LISTA ORDENADA POR SALÁRIO (decrescente) ===");
        var listaSalario = listaColab.OrderByDescending(colab => colab.Salario).ToList();
        ImprimirLista(listaSalario);

        Console.WriteLine("\n=== LISTA DE SALÁRIOS MAIORES QUE R$2.000,00 ===");
        var listaSalarioAlto = listaColab.Where(colab => colab.Salario >= 2000).ToList();
        ImprimirLista(listaSalarioAlto);

        // o => faz o mesmo que a função abaixo faria

        // foreach (var colab in listaSalarioAlto)
        // {
        //     if(colab.Salario >= 2000)
        //     {
        //         Console.WriteLine($"Nome: {colab.Nome} - Salário R$: {colab.Salario} - Data de Registo: {colab.DataRegistro}")
        //     }
        // }

        Console.WriteLine("\n=== COLABORADOR COM O MAIOR SALÁRIO ===");
        var colaboradorCaro = listaColab.MaxBy(colab => colab.Salario);
        Console.WriteLine($"Nome: {colaboradorCaro.Nome} - Salário: R${colaboradorCaro.Salario:F2} - Data de Registro: {colaboradorCaro.DataRegistro}");

        Console.WriteLine("\n=== COLABORADOR COM O MENOR SALÁRIO ===");
        var colaboradorMenorS = listaColab.MinBy(colab => colab.Salario);
        Console.WriteLine($"Nome: {colaboradorMenorS.Nome} - Salário: R${colaboradorMenorS.Salario:F2} - Data de Registro: {colaboradorMenorS.DataRegistro}");

        Console.WriteLine("\n=== PRIMEIRO COLABORADOR DA LISTA ===");
        var primeiroColaborador = listaColab.FirstOrDefault();
        Console.WriteLine($"Nome: {primeiroColaborador.Nome} - Salário: R${primeiroColaborador.Salario:F2} - Data de Registro: {primeiroColaborador.DataRegistro}");

        Console.WriteLine("\n=== ÚLTIMO COLABORADOR DA LISTA ===");
        var ultimoColaborador = listaColab.LastOrDefault();
        Console.WriteLine($"Nome: {ultimoColaborador.Nome} - Salário: R${ultimoColaborador.Salario:F2} - Data de Registro: {ultimoColaborador.DataRegistro}");

        Console.WriteLine("\n=== DASHBOARD GERAL ===");
        var quantidadeColab = listaColab.Count();
        var somaSalarios = listaColab.Sum(c => c.Salario);

        Console.WriteLine($"\nQuantidade de colaboradores: {quantidadeColab}");
        Console.WriteLine($"Soma total de salários: {somaSalarios}");

        Console.WriteLine();
    }

    public static void ImprimirLista(List<Colaborador> lista)
    {
        Console.WriteLine();
        foreach (var colab in lista)
        {
            Console.WriteLine($"Nome: {colab.Nome} - Salário: R${colab.Salario:F2} - Data de Registro: {colab.DataRegistro}");

        }
    }
}