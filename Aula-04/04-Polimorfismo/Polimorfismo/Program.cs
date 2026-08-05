internal class Program
{
    private static void Main(string[] args)
    {
        /*
        polimorfismo : um objeto pode ser tratado de maneiras 
        diferentes dependendo do contexto que é utilizado
        */

        Gato gato = new Gato();
        Cachorro dog = new Cachorro();
        gato.Nome = "Bichano";
        gato.FazerBarulho();
        dog.Nome = "Geraldo";
        dog.FazerBarulho();
    }

    // super classe 
    public class Animal
    {
        public string Nome {get; set;}
        public virtual void FazerBarulho()
        {
            Console.WriteLine("Todo animal faz um barulho");
        }
    }

    // classe filha
    public class Cachorro : Animal
    {
        public override void FazerBarulho()
        {
            Console.WriteLine("Au Au Au");
        }
    }

    public class Gato : Animal
    {
        public override void FazerBarulho()
        {
            Console.WriteLine("Miau Miau");
        }
    }
}