internal class Program
{
    private static void Main(string[] args)
    {
        /*
        classe : abstração de um objeto do mundo real para o mundo computacional
        objeto: é a instância de uma classe
        */

        // instanciar um objeto do tipo aluno
        Aluno aluno01 = new Aluno();
        Aluno aluno02 = new Aluno();

        // atribuir valores
        aluno01.Nome = "Jóse da Silva";
        aluno01.RM = 2444;
        aluno01.DataNascimento = new DateOnly(2010,01,15);

        aluno02.Nome = "João dos Santos";
        aluno02.RM = 1234;
        aluno02.DataNascimento = new DateOnly(2006,12,07);

        // executar os metodos
        aluno01.ApresentarSe();
        aluno02.ApresentarSe();
    }

    public class Aluno // decalaração de uma classe
    {
        // atributos : características do nosso objeto
        public string Nome {get; set;}
        public int RM {get; set;}
        public DateOnly DataNascimento {get; set;}

        // métodos : ações ou funcionalidades
        public void ApresentarSe()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, meu RM é {RM}, nasci na data {DataNascimento}.");
        }
    }
}