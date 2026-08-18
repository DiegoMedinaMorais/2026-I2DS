internal class Program
{
    public class Aluno
    {
        public string? Nome { get; set; }
        public int? Idade { get; set; }

    }
    private static void Main(string[] args)
    {
        Console.WriteLine();
        List<Aluno> listaAlunos = new List<Aluno>();
        Aluno aluno1 = new Aluno { Nome = "Pablo", Idade = 18 };
        Aluno aluno2 = new Aluno { Nome = "Ana", Idade = 17 };
        Aluno aluno3 = new Aluno { Nome = "Mario", Idade = 16 };
        Aluno aluno4 = new Aluno { Nome = "Zeca", Idade = 16 };
        Aluno aluno5 = new Aluno { Nome = "Dora", Idade = 17 };
        listaAlunos.Add(aluno1);
        listaAlunos.Add(aluno2);
        listaAlunos.Add(aluno3);
        listaAlunos.Add(aluno4);
        listaAlunos.Add(aluno5);
        Console.WriteLine();
        foreach (var item in listaAlunos)
        {
            Console.WriteLine($"{item.Nome} - {item.Idade}");
        }
        Console.WriteLine();
        Console.WriteLine("Mudando idade de Ana para 16");
        listaAlunos[1].Idade = 16;
        Console.WriteLine();
        foreach (var item in listaAlunos)
        {
            Console.WriteLine($"{item.Nome} - {item.Idade}");
        }
        Console.WriteLine();
        Console.WriteLine("Removendo Zeca");
        Console.WriteLine();
        listaAlunos.RemoveAt(3);
        foreach (var item in listaAlunos)
        {
            Console.WriteLine($"{item.Nome} - {item.Idade}");
        }
        Console.WriteLine();
    }

}