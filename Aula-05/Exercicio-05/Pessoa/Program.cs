internal class Program
{
    private static void Main(string[] args)
    {
        // Primeiro funcionário

        Funcionario funcionario1 = new Funcionario();
        funcionario1.Nome = "João da Silva";
        funcionario1.IdadeAtual = 32;
        funcionario1.Salario = 2750.00;
        funcionario1.Registro = 125;

        Funcionario funcionario2 = new Funcionario();
        funcionario2.Nome = "Maria de Oliveira";
        funcionario2.IdadeAtual = 26;
        funcionario2.Salario = 4325.50;
        funcionario2.Registro = 116;

        Funcionario funcionario3 = new Funcionario();
        funcionario3.Nome = "Pedro dos santos";
        funcionario3.IdadeAtual = 41;
        funcionario3.Salario = 5700.00;
        funcionario3.Registro = 102;

        Console.WriteLine("=== FUNCIONÁRIOS ===");

        Console.WriteLine("\nFuncionário 1");
        Console.WriteLine($"Nome: {funcionario3.Nome}");
        Console.WriteLine($"Idade: {funcionario3.IdadeAtual}");
        Console.WriteLine($"Registro: {funcionario3.Registro}");
        Console.WriteLine($"Salário: {funcionario3.Salario:F2}");

        Console.WriteLine("\nFuncionário 2");
        Console.WriteLine($"Nome: {funcionario2.Nome}");
        Console.WriteLine($"Idade: {funcionario2.IdadeAtual}");
        Console.WriteLine($"Registro: {funcionario2.Registro}");
        Console.WriteLine($"Salário: {funcionario2.Salario:F2}");

        Console.WriteLine("\nFuncionário 1");
        Console.WriteLine($"Nome: {funcionario3.Nome}");
        Console.WriteLine($"Idade: {funcionario3.IdadeAtual}");
        Console.WriteLine($"Registro: {funcionario3.Registro}");
        Console.WriteLine($"Salário: {funcionario3.Salario:F2}");

        // Envelhecendo os funcionários

        funcionario1.Envelhecer(13);
        funcionario2.Envelhecer(22);
        funcionario3.Envelhecer(30);

        Console.WriteLine("\n=== APÓS ENVELHECER ===");
        Console.WriteLine($"{funcionario1.Nome}: {funcionario1.IdadeAtual}");
        Console.WriteLine($"{funcionario2.Nome}: {funcionario2.IdadeAtual}");
        Console.WriteLine($"{funcionario3.Nome}: {funcionario3.IdadeAtual}");

    }

    public class Pessoa
    {
        public string Nome { get; set; }
        public int IdadeAtual { get; set; }

        public void Envelhecer(int anos)
        {
            IdadeAtual += anos;
        }
    }

    public class Funcionario : Pessoa
    {
        public double Salario { get; set; }
        public int Registro { get; set; }
    }
}