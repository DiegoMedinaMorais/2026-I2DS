internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("=== TRABALHANDO COM PILHAS (FILO) ===");

        // FIFO = first in last out

        // 1 - criar uma nova pilha vazia

        Stack<string> pilhaLivros = new Stack<string>();

        // 2 - adicionar elementos em uma pilha

        pilhaLivros.Push("Dom Quixote");
        pilhaLivros.Push("O Morro dos Ventos Uivantes");
        pilhaLivros.Push("O Cortiço");

        // 3 - percorrer todos os elementos de uma pilha
 
        Console.WriteLine();

        foreach (var livro in pilhaLivros)
        {
            Console.WriteLine(livro);
        }

        // 4 - remover os elementos da pilha

        string livroRemovido = pilhaLivros.Pop();

        Console.WriteLine();
        Console.WriteLine($"O livro retirado foi {livroRemovido}");

        pilhaLivros.Push("Dom Casmurro");
        Console.WriteLine();

        foreach (var livro in pilhaLivros)
        {
            Console.WriteLine(livro);
        }

        Console.WriteLine();
    }
}