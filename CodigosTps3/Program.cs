using System;

namespace CodigosTps3 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Informe seu Peso: ");
            Double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe sua Altura: ");
            Double altura = Convert.ToDouble(Console.ReadLine());

            Double IMC = peso / (altura * altura);

            if (IMC < 18.5) {
                Console.WriteLine("O seu IMC " + IMC + " está abaixo do peso!");
            }
            else if (IMC <= 24.9) {
                Console.WriteLine("O seu IMC " + IMC + " está com peso normal!");
            }
            else if (IMC <= 29.9) {
                Console.WriteLine("O seu IMC " + IMC + " está com sobrepeso!");
            }
            else if (IMC <= 34.9) {
                Console.WriteLine("O seu IMC " + IMC + " está com obesidade grau I!");
            }
            else if (IMC <= 39.9) {
                Console.WriteLine("O seu IMC " + IMC + " está com obesidade grau II!");
            }
            else {
                Console.WriteLine("O seu IMC " + IMC + " está com obesidade grau III!");
            }
        }
    }
}
