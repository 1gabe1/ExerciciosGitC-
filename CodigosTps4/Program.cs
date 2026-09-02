namespace CodigosTps4 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um Numero: ");
            int numero = int.Parse(Console.ReadLine());


            if (numero % 2 == 0) {
                Console.WriteLine($"Numero Par: {numero}");


            }
            else {
                Console.WriteLine($"Numero Impar: {numero}");

            }

        }
    }
}
