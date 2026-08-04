internal class Program
{
    private static void Main(string[] args)
    {
        /* 
          sintaxe:

            enquanto uma condição for verdadeira
                execute um conjunto de  repetições

        for : quando sabemos a quantidade de repetições
        while : quando a repetição depende de uma condição
        do ... while : quando precisa executar ao menos uma vez o bloco de código
        */

        // laço FOR: imprimir números de 1 até o 10

        Console.WriteLine("Imprimir números de 1 até 10 utilizando o laço FOR.");
        for (int numero = 1; numero <= 10; numero++)
        {
            Console.WriteLine(numero);
        }

        // laço FOR: contagem regressiva

        Console.WriteLine("Contado regressivamente de 10 até 0 utilizando o laço FOR.");
        for (int numero = 10; numero >= 0; numero--)
        {
            Console.WriteLine(numero);
        }


        // laço WHILE: imprimir números de 1 até o 10

        Console.WriteLine("Imprimir números de 1 até 10 utilizando o laço WHILE");

        int contador = 1;

        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }

        // laço WHILE: solicitar a senha até acertar

        string senha = "";

        while (senha != "2444") 
        {
            Console.Write("Digite a senha: ");
            senha = Console.ReadLine();
        }

        Console.WriteLine("Acesso permitido!");

        // laço DO ... WHILE: 

        int num;
        do // diferente do while, o do ... while executa o código antes de verificar a condição
        {
            Console.Write("Digite um número positivo: ");
            num = int.Parse(Console.ReadLine());
        } while (num <= 0);
    }
}