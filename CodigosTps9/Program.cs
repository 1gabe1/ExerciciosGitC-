namespace CodigosTps9 {
    internal class Program {
        static void Main(string[] args) {

            Random random = new Random();

            int numeroSecret = random.Next(1, 101);

            int palpite = 0;

            while (palpite != numeroSecret ) {

                Console.WriteLine("Digite um numero: ");
                palpite = int.Parse(Console.ReadLine());

                if (palpite > numeroSecret) {
                    Console.WriteLine("O número secreto etá para baixo..");

                }
                else if (palpite < numeroSecret) {
                    Console.WriteLine("O numero secreto está para cima");

                }
                else {
                    Console.WriteLine("ACERTOUUU!!");
                
                }
            }
        }
    }
}
