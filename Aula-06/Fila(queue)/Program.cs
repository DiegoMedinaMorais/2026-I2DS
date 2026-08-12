internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("=== TRABALHANDO COM FILAS (FIFO) ===");

        // FIFO = first in first out

        // 1 - criar uma nova fila vazia

        Queue<string> filaBanco = new Queue<string>();

        // 2 - adicionar elementos na fila

        filaBanco.Enqueue("Zuleika");       // 0
        filaBanco.Enqueue("Asdrubal");      // 1
        filaBanco.Enqueue("Pafúncio");      // 2
        filaBanco.Enqueue("Epaminondas");   // 3

        // 3 - percorrer elementos de uma fila

        Console.WriteLine();

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // 4 - retirar um elemento da fila

        string pessoaRetirada = filaBanco.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O nome chamado foi: {pessoaRetirada}");

        filaBanco.Enqueue("Lucrácia");
        Console.WriteLine();

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // 5 - verificar se existe um determinado elemento na fila

        string procurar = "Pafúncio";
        bool achou = filaBanco.Contains(procurar);
        Console.WriteLine();

        if (achou)
        {
            Console.WriteLine($"{procurar} está na fila!");
        }
        else
        {
            Console.WriteLine($"{procurar} NÃO está na fila!");
        }
        Console.WriteLine();
    }
}