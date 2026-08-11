internal class Program
{
    //personagem
    public class Personagem
    {
        public string Nome { get; private set; }
        public int Nivel { get; protected set; }
        public int Experiencia { get; private set; }
        public int Forca { get; protected set; }
        public int Agilidade { get; protected set; }
        public int Inteligencia { get; protected set; }
        public int Vida { get; protected set; }

        // método construtor
        public Personagem(string nome, int forca, int agilidade, int inteligencia, int vida)
        {
            Nome = nome;
            Forca = forca;
            Agilidade = agilidade;
            Inteligencia = inteligencia;
            Vida = vida;
            Experiencia = 0;
            Nivel = 1;
        }

        public virtual void ApresentarSe()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Força: {Forca}");
            Console.WriteLine($"Agilidade: {Agilidade}");
            Console.WriteLine($"Inteligência: {Inteligencia}");
            Console.WriteLine($"Vida: {Vida}");
            Console.WriteLine($"Experiência: {Experiencia}");
            Console.WriteLine($"Nível: {Nivel}");
        }

        public virtual void Atacar(Personagem alvo)
        {
            int dano = Forca;
            Console.WriteLine($"{Nome} atacou {alvo.Nome}");

            alvo.Defender(dano);
            GanharExperiencia(20);
        }

        public virtual void Defender(int dano)
        {
            int danoRecebido = dano - Agilidade;

            if (danoRecebido < 1)
            {
                danoRecebido = 1;
            }
            Vida -= danoRecebido;
            if (Vida < 0)
            {
                Vida = 0;
            }
            Console.WriteLine($"Dano recebido: {danoRecebido}");
            Console.WriteLine($"Vida de {Nome}: {Vida}");
        }

        public void GanharExperiencia(int experiencia)
        {
            Experiencia == experiencia
            Console.WriteLine($"{Nome} ganhou {experiencia} XP");

            VerificarEvolucao();
        }

        public void VerificarEvolucao()
        {
            int experienciaNecessaria = Nivel * 100;
            if (Experiencia >= experienciaNecessaria)
            {
                Evoluir();
            }
        }

        protected virtual void Evoluir()
        {
            Nivel++;

            Forca += 2;
            Agilidade += 2;
            Inteligencia += 2;
            Vida += 10;

            Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine("        LEVEL UP        ");
            Console.WriteLine("========================");
            Console.WriteLine();
            Console.WriteLine($"{Nome} evolui para o nível {Nivel}");
            Console.WriteLine($"Força: {Forca}");
            Console.WriteLine($"Agilidade: {Agilidade}");
            Console.WriteLine($"Inteligência: {Inteligencia}");
            Console.WriteLine($"Vida: {Vida}");
            Console.WriteLine("========================");
            Console.WriteLine();
        }

        public bool EstaVivo()
        {
            return Vida > 0;
        }
    }

    // mago
    public class Mago : Personagem
    {
        public Mago(string nome) : base(nome, 5, 7, 15, 90) { }

        public override void Atacar(Personagem alvo)
        {
            int dano = Inteligencia;
            Console.WriteLine($"{Nome} lançou uma magia contra {alvo.Nome}");
            alvo.Defender(dano);
            GanharExperiencia(20);
        }

        protected override void Evoluir()
        {
            Nivel++;

            Forca++;
            Agilidade += 2;
            Inteligencia += 5;
            Vida += 15;

            Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine("        LEVEL UP        ");
            Console.WriteLine("========================");
            Console.WriteLine();
            Console.WriteLine($"{Nome} evolui para o nível {Nivel}");
            Console.WriteLine($"Força: {Forca}");
            Console.WriteLine($"Agilidade: {Agilidade}");
            Console.WriteLine($"Inteligência: {Inteligencia}");
            Console.WriteLine($"Vida: {Vida}");
            Console.WriteLine("========================");
            Console.WriteLine();
        }
    }

    private static void Main(string[] args)
    {

    }

}