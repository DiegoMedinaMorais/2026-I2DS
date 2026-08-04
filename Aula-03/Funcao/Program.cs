internal class Program
{
    private static void Main(string[] args)
    {
        Ola("Cristiano");
        Ola("Maria");
        Ola("João");

        Console.WriteLine("A soma de 5 e 3 é: "+ Calcular(5,3,"+"));
        Console.WriteLine("A subtração de 5 e 3 é: " + Calcular(5, 3, "-"));
        Console.WriteLine("[teste com uso de símbolo inválido] A subtração de 5 e 3 é: " + Calcular(5, 3, "#"));
    }

    // função sem retorno e sem parâmetros 
    /*
    public static void Ola()
    {
        Console.WriteLine("Olá, seja bem vindo!");
    }
    */


    // função sem retorno e com parâmetro nome
    public static void Ola(string nome)
    {
        Console.WriteLine("Olá " + nome + ", seja bem vindo(a)!");
    }

    public static double Calcular(double num1, double num2, string operador)
    {
        double resultado = 0;
        switch (operador)
        {
            case "+":
                resultado = num1 + num2;
                break;
            case "-":
                resultado = num1 - num2;
                break;
            case "*":
                resultado = num1 * num2;
                break;
            case "/":
                resultado = num1 / num2;
                break;
            default:
                Console.WriteLine("ERRO: Operador informado não é válido!");
                break;
        }
        return resultado;
    }
}