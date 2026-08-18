internal class Program
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Prioridade { get; set; }
    }
    private static void Main(string[] args)
    {
        Queue<Cliente> clientes = new Queue<Cliente>();
        Stack<Cliente> clientesAtendidos = new Stack<Cliente>();
        Cliente cliente1 = new Cliente { Nome = "Jhonny", Prioridade = "Urgente" };
        Cliente cliente2 = new Cliente { Nome = "Bob", Prioridade = "Não urgente" };
        Cliente cliente3 = new Cliente { Nome = "Anny", Prioridade = "Urgência mediana" };
        Cliente cliente4 = new Cliente { Nome = "Zeca", Prioridade = "Não urgente" };
        Cliente cliente5 = new Cliente { Nome = "Maria", Prioridade = "Urgente" };
        Cliente cliente6 = new Cliente { Nome = "Diego", Prioridade = "Urgência mediana" };
        clientes.Enqueue(cliente1);
        clientes.Enqueue(cliente2);
        clientes.Enqueue(cliente3);
        clientes.Enqueue(cliente4);
        clientes.Enqueue(cliente5);
        clientes.Enqueue(cliente6);
        
        int contagemAtendidos = 0;

        while (contagemAtendidos < 4)
        {
            Cliente clienteRemovido = clientes.Dequeue();
            clientesAtendidos.Push(clienteRemovido);
            Console.WriteLine();
            Console.WriteLine($"Cliente atendido: {clienteRemovido.Nome}. Removido da lista de clientes e \nadicionado na lista de clientes atendidos.");
            contagemAtendidos++;
        }

        Console.WriteLine("Clientes ainda na fila:");
        Console.WriteLine();
        foreach (var item in clientes)
        {
            Console.WriteLine($"Nome: {item.Nome} | Prioridade: {item.Prioridade}");
        }
        Console.WriteLine();
        Console.WriteLine("Clientes atendidos:");
        Console.WriteLine();
        foreach (var item in clientesAtendidos)
        {
            Console.WriteLine($"Nome: {item.Nome} | Prioridade: {item.Prioridade}");
        }
        Console.WriteLine();
    }
}