namespace CodigosTps5 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira uma nota de Prova: ");
            double notaProva = double.Parse(Console.ReadLine());

            if (notaProva >= 0 && notaProva <= 10) {

                if (notaProva <= 4.9) {
                    Console.WriteLine("Insuficiente..");

                }
                else if (notaProva <= 6.9) {
                    Console.WriteLine("Regular :3");

                }
                else if (notaProva <= 8.9) {
                    Console.WriteLine("Bomm :>");

                }
                else {
                    Console.WriteLine("Excelente");

                }

            }
            else {
                Console.WriteLine("ERRO - NOTA INVALIDA");



            }

            
        }
    }
}
