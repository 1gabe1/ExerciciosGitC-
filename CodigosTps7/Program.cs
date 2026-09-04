namespace CodigosTps7 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe um Numero: ");
            int numero = int.Parse(Console.ReadLine());

            while (numero >= 0) {
                Console.Write(numero);
               
                if (numero != 0) {

                    Console.Write(", ");
                }

                numero--;
            }


        }
    }
}
