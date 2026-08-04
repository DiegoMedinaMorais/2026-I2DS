internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Digite o valor: ")
        int valor = int.Parse(Console.ReadLine());

        int nota = 100; // 100, 50, 20, 10, 5, 2 , 1
        int valor2 = 0;
        while (nota != valor)
        {
            switch (nota)
            {
                case 100:
                    valor2 += nota;
                    if (valor2 > valor)
                    {
                        valor2 -= nota;
                        nota = 50;
                    }
                case 50:
                    valor2 += nota;
                    if (valor2 > valor)
                    {
                        valor2 -= nota;
                        nota = 20;
                    }
                case 20:
                    valor2 += nota;
                    if (valor2 > valor)
                    {
                        valor2 -= nota;
                        nota = 10;
                    }
                case 10:
                    valor2 += nota;
                    if (valor2 > valor)
                    {
                        valor2 -= nota;
                        nota = 5;
                    }
                case 5:
                    valor2 += nota;
                    if (valor2 > valor)
                    {
                        valor2 -= nota;
                        nota = 2;
                    }
                case 2:
                    valor2 += nota;
                    if (valor2 > valor)
                    {
                        valor2 -= nota;
                        nota = 1;
                    }
                case 1:
                    valor2 += nota;
            }
        }
    }
}