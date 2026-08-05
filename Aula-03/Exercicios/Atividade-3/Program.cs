internal class Program
{
    private static void Main(string[] args)
    {
        // feita

        Console.Write("Digite seu nome : ");
        string nome = Console.ReadLine();

        Console.Write("Digite a primeira nota: ");
        int nota1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        int nota2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        int nota3 = int.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine("Aluno: " + nome);
        Console.WriteLine("Média: " + media);

        if (media >= 7)
        {
            Console.WriteLine("Situação: Aprovado");
        }
        else if (media >= 5)
        {
            Console.WriteLine("Situação: Recuperação");
        }
        else
        {
            Console.WriteLine("Situação: Reprovado");
        }
    }
}