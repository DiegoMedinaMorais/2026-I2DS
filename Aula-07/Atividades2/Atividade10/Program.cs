internal class Program
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Nota { get; set; }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine();
        List<Aluno> alunos = new List<Aluno>();
        Aluno aluno1 = new Aluno { Nome = "Robbinson", Nota = 6 };
        Aluno aluno2 = new Aluno { Nome = "Anny", Nota = 2 };
        Aluno aluno3 = new Aluno { Nome = "Jhonny", Nota = 9 };
        Aluno aluno4 = new Aluno { Nome = "Diego", Nota = 10 };
        Aluno aluno5 = new Aluno { Nome = "Daniel", Nota = 8 };
        Aluno aluno6 = new Aluno { Nome = "Murilo", Nota = 3 };
        alunos.Add(aluno1);
        alunos.Add(aluno2);
        alunos.Add(aluno3);
        alunos.Add(aluno4);
        alunos.Add(aluno5);
        alunos.Add(aluno6);
        Console.WriteLine("Lista de alunos:");
        Console.WriteLine();
        foreach (var item in alunos)
        {
            Console.WriteLine($"Nome: {item.Nome} - Nota: {item.Nota}");
        }
        Console.WriteLine();
        Console.WriteLine("Lista de alunos com nota maior que 7 e ordem decrescente:");
        Console.WriteLine();
        var alunosFiltrados = alunos.Where(a => a.Nota >= 7).OrderByDescending(a => a.Nota);
        foreach (var item in alunosFiltrados)
        {
            Console.WriteLine($"Nome: {item.Nome} - Nota: {item.Nota}");
        }
        Console.WriteLine();
    }
}