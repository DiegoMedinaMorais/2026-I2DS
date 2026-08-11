internal class Program
{
    private static void Main(string[] args)
    {
        // primeiro livro
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "Zeca";
        aluno1.Email = "ZecaOZeca@gmail.com";
        aluno1.Nascimento = new DateOnly(2009,07,29);
        aluno1.RM = 1320;

        // segundo livro
        Aluno aluno2 = new Aluno();
        aluno2.Nome = "Anny";
        aluno2.Email = "Anny928@gmail.com";
        aluno2.Nascimento = new DateOnly(2009,04,13);
        aluno2.RM = 8436;

        // terceiro livro
        Aluno aluno3 = new Aluno();
        aluno3.Nome = "Guilherme";
        aluno3.Email = "Venoso16@gmail.com";
        aluno3.Nascimento = new DateOnly(2010,03,22);
        aluno3.RM = 9286;

        // exibindo os livros na tela
        Console.WriteLine("\n==== LIVROS ====");
        Console.WriteLine($"\nAluno 01: {aluno1.Nome} | Email: {aluno1.Email} | RM: {aluno1.RM} | Data de nascimento: {aluno1.Nascimento}");
        Console.WriteLine($"\nAluno 02: {aluno2.Nome} | Email: {aluno2.Email} | RM: {aluno2.RM} | Data de nascimento: {aluno2.Nascimento}");
        Console.WriteLine($"\nAluno 03: {aluno3.Nome} | Email: {aluno3.Email} | RM: {aluno3.RM} | Data de nascimento: {aluno3.Nascimento}");
    }

    public class Aluno
    {
        public string Nome { get; set; }

        public int RM { get; set; }

        public DateOnly Nascimento { get; set; }

        public string Email { get; set; }
    }
}