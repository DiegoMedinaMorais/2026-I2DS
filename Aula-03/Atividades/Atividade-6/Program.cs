internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite um número: ");

        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        int vezes = 10;

    }
    public static void Contar(int numero, int vezes)
    {
        for (int i = 1; i <= vezes; i++)
        {
            Console.WriteLine(numero + " x " + i + " = " + numero * i);
        }

    }


}