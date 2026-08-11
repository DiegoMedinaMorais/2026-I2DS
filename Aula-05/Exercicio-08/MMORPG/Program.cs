using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Escolher personagem
        Console.WriteLine("\nEscolha um personagem:\n");
        Console.WriteLine("Digite 1 para o mago:\n7 de vida\n3 de força\n5 de inteligência\n3 de agilidade\n");
        Console.WriteLine("Digite 2 para cavalheiro:\n10 de vida\n2 de força\n3 de inteligência\n1 de agilidade\n");
        Console.WriteLine("Digite 3 para elfo:\n4 de vida\n4 de força\n1 de inteligência\n5 de agilidade\n");

        int escolha = int.Parse(Console.ReadLine());
        Personagem jogador = null;

        if (escolha == 1)
        {
            jogador = new Personagem("Mago", 1, 3, 3, 5, 7, false);
        }
        else if (escolha == 2)
        {
            jogador = new Personagem("Cavalheiro", 1, 2, 1, 3, 10, false);
        }
        else if (escolha == 3)
        {
            jogador = new Personagem("Elfo", 1, 4, 5, 1, 4, false);
        }
        Console.WriteLine($"\n--- Status do {jogador.Nome} ---");
        Console.WriteLine($"Nível: {jogador.Nivel}");
        Console.WriteLine($"Vida: {jogador.Vida}");
        Console.WriteLine($"Inteligência: {jogador.Inteligencia}");
        Console.WriteLine($"Agilidade: {jogador.Agilidade}");
        Console.WriteLine($"Força: {jogador.Forca}");
        Console.WriteLine($"Defendendo: {jogador.Defendendo}");

        while (jogador != null)
        {
            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadLine();
            Console.WriteLine("Um inimigo aparece:");


        }
    }

    public class Personagem
    {
        public string Nome { get; protected set; }
        public int Nivel { get; protected set; }
        public int Forca { get; protected set; }
        public int Agilidade { get; protected set; }
        public int Inteligencia { get; protected set; }
        public int Vida { get; protected set; }
        public bool Defendendo { get; protected set; }

        public Personagem(string nome, int nivel, int forca, int agilidade, int inteligencia, int vida, bool defendendo)
        {
            this.Nome = nome;
            this.Nivel = nivel;
            this.Forca = forca;
            this.Agilidade = agilidade;
            this.Inteligencia = inteligencia;
            this.Vida = vida;
            this.Defendendo = defendendo;
        }

        public void Evoluir()
        {
            Nivel++;
            Forca += 2;
            Agilidade += 2;
            Inteligencia += 2;
            Vida += 2;
        }

        public void Atacar(Personagem vitima)
        {
            if (vitima.Defendendo == false)
            {
                vitima.Vida -= Forca;
            }
            else
            {
                vitima.Vida -= (Forca - 3);
            }
        }

        public void Defender()
        {
            Defendendo = true;
        }
    }


    public class Mago : Personagem
    {
        public Mago()
        {
            Nome = "Tim";
            Forca = 3;
            Inteligencia = 5;
            Agilidade = 3;
            Nivel = 1;
            Vida = 7;
            Defendendo = false;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Eu sou {Nome}, um mago poderoso.");
            Console.WriteLine($"Mago {Nome}:\nNível: {Nivel}\nForça: {Forca}\nAgilidade: {Agilidade}\nInteligência: {Inteligencia}\nVida: {Vida}");
        }
    }
    public class Cavalheiro : Personagem
    {
        public Cavalheiro()
        {
            Nome = "John";
            Forca = 2;
            Inteligencia = 3;
            Agilidade = 1;
            Nivel = 1;
            Vida = 10;
            Defendendo = false;

        }

        public void Apresentar()
        {
            Console.WriteLine($"Eu sou {Nome}, um cavalheiro forte.");
            Console.WriteLine($"Cavalheiro {Nome}:\nNível: {Nivel}\nForça: {Forca}\nAgilidade: {Agilidade}\nInteligência: {Inteligencia}\nVida: {Vida}");
        }
    }
    public class Elfo : Personagem
    {
        public Elfo()
        {
            Nome = "Billy";
            Forca = 4;
            Inteligencia = 1;
            Agilidade = 5;
            Nivel = 1;
            Vida = 4;
            Defendendo = false;

        }

        public void Apresentar()
        {
            Console.WriteLine($"Eu sou {Nome}, um elfo maligno.");
            Console.WriteLine($"Elfo {Nome}:\nNível: {Nivel}\nForça: {Forca}\nAgilidade: {Agilidade}\nInteligência: {Inteligencia}\nVida: {Vida}");
        }
    }
}
