internal class Program
{
    public class Aluno
    {
        public string Nome {get; set;}
        public int Idade {get; set;}
        public int Nota {get; set;}
    }
    private static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno{Nome = "Zeca", Idade = 14, Nota = 7};
        Aluno aluno2 = new Aluno { Nome = "Bob", Idade = 15, Nota = 8 };
        Aluno aluno3 = new Aluno { Nome = "Maria", Idade = 16, Nota = 2 };
        Aluno aluno4 = new Aluno { Nome = "John", Idade = 15, Nota = 5 };
        Aluno aluno5 = new Aluno { Nome = "Ana", Idade = 15, Nota = 1 };
        Aluno aluno6 = new Aluno { Nome = "Simon", Idade = 16, Nota = 10 };
        Aluno aluno7 = new Aluno { Nome = "Isa", Idade = 14, Nota = 7 };
        Aluno aluno8 = new Aluno { Nome = "Pablo", Idade = 14, Nota = 9 };

        List<Aluno> alunos = new List<Aluno>();

        alunos.Add(aluno1);
        alunos.Add(aluno2);
        alunos.Add(aluno3);
        alunos.Add(aluno4);
        alunos.Add(aluno5);
        alunos.Add(aluno6);
        alunos.Add(aluno7);
        alunos.Add(aluno8);

        Console.WriteLine();

        Console.WriteLine("Ordenada por nome");
        var listaOrdenadaNome = alunos.OrderBy(a => a.Nome).ToList();
        ImprimirLista(listaOrdenadaNome);
        Console.WriteLine("Ordenada por idade");
        var listaOrdenadaIdade = alunos.OrderBy(a => a.Idade).ToList();
        ImprimirLista(listaOrdenadaIdade);
        Console.WriteLine("Ordenada por nota");
        var listaOrdenadaNota = alunos.OrderBy(a => a.Nota).ToList();
        ImprimirLista(listaOrdenadaNota);
        Console.WriteLine("Ordenada por nota maior pra menor");
        var listaOrdenadaNotaD = alunos.OrderByDescending(a => a.Nota).ToList();
        ImprimirLista(listaOrdenadaNotaD);


        // classe aluno nome idade nota
        // cadastro 8 alunos
        // utiliza linq apresenta alunos ord nome alunos ord idade     alunos ord nota alunos ord maior nota pra menor
    }
    public static void ImprimirLista(List<Aluno> lista)
    {
        Console.WriteLine();
        foreach (var item in lista)
        {
            Console.WriteLine($"Nome: {item.Nome} - Idade: {item.Idade} - Nota: {item.Nota}");
        }
        Console.WriteLine();
    }
}