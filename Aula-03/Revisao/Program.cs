internal class Program
{
    private static void Main(string[] args)
    {
        // VARIÁVEIS ------------------------------------------------------------------

        // criar uma variável
        // sintaxe: tipo nome = valor 

        // tipos de dados primários

        // int = representação de números inteiros
        int idade = 21;
        // double = representação de números decimais
        double salário = 10352.25;
        float altura = 1.75f;
        decimal peso = 71.35m;

        // string = representação de um texto alphanumérico
        string nome = "Thomaz";
        string celular = "14996667788";
        string cpf = "123.456.789-03";
        // bool = representa um número booleano (true ou false)
        bool estudante = true;
        bool temLimite = false;

        // datetime = representação de data e hora
        DateTime cadastro = new DateTime(2026, 08, 04, 09, 15, 32); // ano mês dia, hora minutos segundos
        DateOnly nascimento = new DateOnly(2010, 01, 20);

        // OPERADORES ARITMÉTICOS ------------------------------------------------------------------

        /*
        + : somar
        - : subtrair
        * : multiplicar
        / : divisão
        % : resto da divisão
        ^ : exponenciação
        = : atribui o valor
        */

        int n1 = 10;
        int n2 = 3;
        double resultado = 0;

        // calcular a soma
        resultado = n1 + n2;
        Console.WriteLine("A soma dos dois números é: " + resultado);

        // calcular a subtração
        resultado = n1 - n2;
        Console.WriteLine("A subtração dos dois números é: " + resultado);

        // calcular a multiplicação
        resultado = n1 * n2;
        Console.WriteLine("A multiplicação dos dois números é: " + resultado);

        // calcular a divisão
        resultado = n1 / n2;
        Console.WriteLine("A divisão dos dois números é: " + resultado);

        // calcular o resto da divisão
        resultado = n1 % n2;
        Console.WriteLine("O resto da divisão dos dois números é: " + resultado);

        // calcular a potência
        resultado = n1 ^ n2;
        Console.WriteLine("O número um elevado ao número dois é: " + resultado);

        // operador de incremento ++
        Console.WriteLine("Valor de N1: " + n1);
        n1++; // aumenta o número atual em + 1
        Console.WriteLine("Valor de N1: " + n1);

        // operador de atribuição +=
        n1 += 10; // mesma coisa que linha de baixo só que menor
        n1 = n1 + 10;
        Console.WriteLine("Valor de N1: " + n1);

        // operador de decremento --
        Console.WriteLine("Valor de N1: " + n1);
        n1--; // aumenta o número atual em + 1
        Console.WriteLine("Valor de N1: " + n1);

        // operador de atribuição com subtração -=
        n1 -= 10; // mesma coisa que linha de baixo só que menor
        n1 = n1 + 10;
        Console.WriteLine("Valor de N1: " + n1);

        // OPERADORES RELACIONAIS ------------------------------------------------------------------

        // operadores relacionais = realizam comparações

        /*
        > : maior que
        < : menor que
        >= : maior ou igual
        <= : menor ou igual
        == : igual
        != : diferente
        */

        idade = 13;
        Console.WriteLine("A idade informada é maior que 18? " + (idade > 18));

        peso = 55;
        Console.WriteLine("O peso informado é menor que 60kg? " + (peso < 60));

        estudante = false;
        Console.WriteLine("O nome informado é de um estudante? " + (estudante == true));

        // OPERADORES LÓGICOS ------------------------------------------------------------------

        // operadores lógicos = permitem combinar duas ou mais condições     

        /*
        && : operador lógico "E/AND"                                                                                                                                                                                                                                
        || : operador lógico "OU/OR"
        ! : operador de negação, inverte a lógica do resultado
        */

        peso = 84;
        altura = 170;
        
        Console.WriteLine("Peso: " + peso + "kg \nAltura " + altura + "m");

        Console.WriteLine("Peso igual ou menor que 100kg (&&) altura maior que 1,80m");
        Console.WriteLine((peso <= 100) && (altura > 180));

        Console.WriteLine("Peso igual ou menor que 100kg ou (||) altura maior que 1,80m");
        Console.WriteLine((peso <= 100) || (altura > 180));
    }   
}                                                                                               