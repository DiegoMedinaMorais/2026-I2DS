internal class Program
{
    private static void Main(string[] args)
    {
        // feita
        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Digite o símbolo da operação: ");
        string operador = Console.ReadLine();
        Calcular(num1, num2, operador);
    }

    public static double Calcular(int num1, int num2, string operador)
    {
        double resultado = 0;

        switch (operador)
        {
            case "+":
                resultado = num1 + num2;
                Console.WriteLine(num1 + " + " + num2 + " = " + resultado);
                break;
            case "-":
                resultado = num1 - num2;
                Console.WriteLine(num1 + " - " + num2 + " = " + resultado);
                break;
            case "*":
                resultado = num1 * num2;
                Console.WriteLine(num1 + " * " + num2 + " = " + resultado);
                break;
            case "/":
                resultado = num1 / num2;
                Console.WriteLine(num1 + " / " + num2 + " = " + resultado);
                break;
            default:
                Console.WriteLine("Operador inválido.");
                break;
        }

        return resultado;
    }
}