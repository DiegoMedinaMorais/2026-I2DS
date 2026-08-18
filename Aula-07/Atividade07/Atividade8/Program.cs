internal class Program
{
    public class Funcionario
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
    }
    private static void Main(string[] args)
    {
        Dictionary<int, Funcionario> funcionarios = new Dictionary<int, Funcionario>();
        Funcionario func1 = new Funcionario { Matricula = 9284, Nome = "Anny", Salario = 7250.00 };
        Funcionario func2 = new Funcionario { Matricula = 0372, Nome = "Diego", Salario = 9800.99 };
        Funcionario func3 = new Funcionario { Matricula = 2957, Nome = "Ronaldo", Salario = 4000.20 };
        Funcionario func4 = new Funcionario { Matricula = 1985, Nome = "Jhonny", Salario = 8500.60 };
        Funcionario func5 = new Funcionario { Matricula = 8687, Nome = "Daniel", Salario = 500.00 };
        funcionarios.Add(1, func1);
        funcionarios.Add(2, func2);
        funcionarios.Add(3, func3);
        funcionarios.Add(4, func4);
        funcionarios.Add(5, func5);

        Console.WriteLine();
        Console.WriteLine("Lista de funcionários:");
        Console.WriteLine();
        foreach (var item in funcionarios)
        {
            Console.WriteLine($"Key: {item.Key} | Nome: {item.Value.Nome} - Matrícula: {item.Value.Matricula} - Salário: {item.Value.Salario}");
        }
        Console.WriteLine();
        Console.WriteLine("Lista de funcionários com salário menor para maior:");
        var funcionariosSalario = funcionarios.OrderBy(func => func.Value.Salario).ToList();
        Console.WriteLine();
        foreach (var item in funcionariosSalario)
        {
            Console.WriteLine($"Key: {item.Key} | Nome: {item.Value.Nome} - Matrícula: {item.Value.Matricula} - Salário: {item.Value.Salario}");
        }
        Console.WriteLine();
    }
}