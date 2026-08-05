internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite um número: ");

        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        int vezes = 10;
        Contar(numero, vezes);

    }
    public static void Contar(int numero, int vezes)
    {
        for (int i = 1; i <= vezes; i++)
        {
            Console.WriteLine(numero + " x " + i + " = " + numero * i);
        }

        Console.Write("Deseja continuar? digite 1 para sim, 2 para não: ");
        int escolha = int.Parse(Console.ReadLine());

        if (escolha == 1)
        {
            Contar(numero, vezes+10);
        } 
    }
}