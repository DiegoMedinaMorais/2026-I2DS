internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite a temperatura em celsius: ");
       int celsius = int.Parse(Console.ReadLine());

       int fahrenheit = (celsius * 9 / 5) + 32;
       Console.WriteLine(celsius + "°C são " + fahrenheit + "°F.");
    }
}