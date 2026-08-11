internal class Program
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Velocidade { get; set; }

        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Desacelerar()
        {
            Velocidade -= 10;
            if (Velocidade <= 0)
            {
                Velocidade = 0;
            }
        }
    }
    private static void Main(string[] args)
    {
        Carro carro1 = new Carro();

        carro1.Marca = "Honda";
        carro1.Modelo = "CR-V";
        carro1.Velocidade = 20;

        Carro carro2 = new Carro();

        carro2.Marca = "Honda";
        carro2.Modelo = "Civic";
        carro2.Velocidade = 30;

        Carro carro3 = new Carro();

        carro3.Marca = "Onix";
        carro3.Modelo = "Tracker";
        carro3.Velocidade = 50;

        Console.WriteLine($"\nCarro 1:\nMarca: {carro1.Marca}\nModelo: {carro1.Modelo}\nVelocidade {carro1.Velocidade}\n");
        Console.WriteLine($"Carro 2:\nMarca: {carro2.Marca}\nModelo: {carro2.Modelo}\nVelocidade {carro2.Velocidade}\n");
        Console.WriteLine($"Carro 3:\nMarca: {carro3.Marca}\nModelo: {carro3.Modelo}\nVelocidade {carro3.Velocidade}\n");

        // teste de velocidade e aceleração / desaceleração
        
        carro1.Acelerar();
        Console.WriteLine(carro1.Velocidade);

        carro1.Desacelerar();
        Console.WriteLine(carro1.Velocidade);

        carro1.Desacelerar();
        Console.WriteLine(carro1.Velocidade);

        carro1.Desacelerar();
        Console.WriteLine(carro1.Velocidade);

        carro1.Desacelerar();
        Console.WriteLine(carro1.Velocidade);
    }
}