namespace Codigostps2 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite a temperatura em Graus Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            Double Fahrenheit = Fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine($"Valor de Celsius para Fahrenheit: {Fahrenheit:F2} °F");

            Double Kelvin = Kelvin = celsius + 273.15;
            Console.WriteLine($"Valor de Celsius para Kelvin: {Kelvin:F2} K");

        }
    }
}
