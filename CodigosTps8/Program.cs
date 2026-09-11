namespace CodigosTps8 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira um Numero: ");
            int numero = int.Parse(Console.ReadLine());

            int contador = 1;

            while (contador <= 10 ) {

                Console.WriteLine($"{numero} X {contador} = {numero * contador}");

                contador++;

                
            }



        }
    }
}
