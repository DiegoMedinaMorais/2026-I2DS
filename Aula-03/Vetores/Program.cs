internal class Program
{
    private static void Main(string[] args)
    {
        /*
        vetores e matrizes

        vetor : estrutura de dados utilizada para armazenar vários valores de um
        mesmo tipo dentro de uma única variável

        sintaxe:
        tipo[] nome = new tipo[tamanho]
        */

        // iniciar um vetor -> lista de frutas
        string[] listaFrutas = {"Maça","Manga","Morango","Melancia","Melão"};

        Console.Write("Acessar o terceiro elemento da lista: ");
        Console.WriteLine(listaFrutas[2]);

        Console.WriteLine("Alterando o segundo elemento da lista para banana.");
        listaFrutas[1] = "Banana";

        for (int indice = 0; indice < listaFrutas.Length; indice++)
        {
            Console.WriteLine(listaFrutas[indice]);
        }

        foreach (string fruta in listaFrutas)
        {
            Console.WriteLine(fruta);
        }

    }
}