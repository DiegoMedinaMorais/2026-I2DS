using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        // comentário de linha
        /* 
        comentário de bloco
        várias linhas
         */

        // escreve uma linha de texto na tela
        Console.WriteLine("Programação Orientada a Objetos\n");

        Console.WriteLine("Abstração - 1° Pilar da POO");

        /* criar uma classe em C# 
           a classe deve ser declarada fora do bloco de programa 
        */

        // criar um objeto a partir de uma classe

        Pet pet1 = new Pet();

        pet1.nome = "Totó";
        pet1.tipo = "Cachorro";
        pet1.idade = 3;

        pet1.MostrarNome();


        Pet pet2 = new Pet();

        pet2.nome = "Mingau";
        pet2.tipo = "Gato";
        pet2.idade = 8;

        pet2.MostrarNome();
    }
     public class Pet // nome da classe sempre inicia com letras MAIUSCÚLAS
    {
        // declaração dos atributos 
        public string nome;
        public string tipo;
        public int idade;

        // declaração dos métodos
        public void MostrarNome()
        {
            Console.WriteLine("Meu nome é " + this.nome);
        }
    }
}