internal class Program
{
    public class Aluno
    {
        public int Id { get; set; }

        // ? = informação pode ser nula, não é obrigatoria
        public string? Nome { get; set; }
        public string? Matricula { get; set; }

    }
    private static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("=== TRABALHANDO COM LISTAS ===");

        // 1 - iniciar uma nova lista
        List<Aluno> listaALunos = new List<Aluno>();

        Aluno aluno1 = new Aluno { Id = 1, Nome = "Zuleika", Matricula = "12345" };
        Aluno aluno2 = new Aluno { Id = 2, Nome = "Pafúncio", Matricula = "25256" };
        Aluno aluno3 = new Aluno { Id = 3, Nome = "Asdrubal", Matricula = "85235" };

        // 2 - incluir elemento em uma lista
        listaALunos.Add(aluno1);
        listaALunos.Add(aluno2);
        listaALunos.Add(aluno3);

        // 3 - percorrer todos os elementos de uma lista

        Console.WriteLine();

        foreach (var aluno in listaALunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Matricula}");
        }

        // 4 - alterar o elemento da lista

        listaALunos[1].Matricula = "55555";
        listaALunos[2].Nome = "Eleutério";
        Console.WriteLine();

        foreach (var aluno in listaALunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Matricula}");
        }

        // 5 - quantidade de elementos da listas

        Console.WriteLine();
        Console.WriteLine($"Quantidade de elementos na lista: {listaALunos.Count()}");

        // 6 - remover um elemento da lista por índice

        listaALunos.RemoveAt(0);
        Console.WriteLine();

        foreach (var aluno in listaALunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Matricula}");
        }

        // 7 - remover um elemento da lista por objeto

        listaALunos.Remove(aluno3);
        Console.WriteLine();

        foreach (var aluno in listaALunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Matricula}");
        }

        Console.WriteLine();

        // 8 - remover todos os elementos da lista

        listaALunos.Clear();
    }
}