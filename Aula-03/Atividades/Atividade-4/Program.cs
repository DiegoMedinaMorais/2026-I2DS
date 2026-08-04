internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Digite o valor: ");
        int valor = int.Parse(Console.ReadLine());

        int nota = 100; // 100, 50, 20, 10, 5, 2 , 1
        int valor2 = 0;
        int qntd100 = 0;
        int qntd50 = 0;
        int qntd20 = 0;
        int qntd10 = 0;
        int qntd5 = 0;
        int qntd2 = 0;
        int qntd1 = 0;
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
                    else
                    {
                        qntd100++;
                    }
                case 50:
                    valor2 += nota;
                    if (valor2 > valor)
                    {
                        valor2 -= nota;
                        nota = 20;
                    }
                    else
                    {
                        qntd50++;
                    }
                case 20:
                    valor2 += nota;
                    if (valor2 > valor)
                    {
                        valor2 -= nota;
                        nota = 10;
                    }
                    else
                    {
                        qntd20++;
                    }
                case 10:
                    valor2 += nota;
                    if (valor2 > valor)
                    {
                        valor2 -= nota;
                        nota = 5;
                    }
                    else
                    {
                        qntd10++;
                    }
                case 5:
                    valor2 += nota;
                    if (valor2 > valor)
                    {
                        valor2 -= nota;
                        nota = 2;
                    }
                    else
                    {
                        qntd5++;
                    }
                case 2:
                    valor2 += nota;
                    if (valor2 > valor)
                    {
                        valor2 -= nota;
                        nota = 1;
                    }
                    else
                    {
                        qntd2++;
                    }
                case 1:
                    valor2 += nota;
                        qntd1++;
                
            }
        }
        if (qntd100 != 0);
        {
            Console.WriteLine(qntd100 + " notas de 100");
        }
        if (qntd50 != 0);
        {
            Console.WriteLine(qntd50 + " notas de 50");
        }
        if (qntd20 != 0);
        {
            Console.WriteLine(qntd20 + " notas de 20");
        }
        if (qntd10 != 0);
        {
            Console.WriteLine(qntd10 + " notas de 10");
        }
        if (qntd5 != 0);
        {
            Console.WriteLine(qntd5 != 0 + " notas de 5");
        }
        if (qntd2 != 0);
        {
            Console.WriteLine(qntd2 + " notas de 2");
        }
        if (qntd1 != 0);
        {
            Console.WriteLine(qntd1 + " notas de 1");
        }

    }
}