namespace CodigosTps6 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um Valor Salarial Bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine());

            double desconto;
           
            if (salarioBruto <= 2000) {
                desconto = salarioBruto * 0.05;

            }
            else if (salarioBruto <= 4000) {
                desconto = salarioBruto * 0.10;
            }
            else if (salarioBruto <= 6000) {
                desconto = salarioBruto * 0.15;
            }
            else {
                desconto = salarioBruto * 0.20;
            }

            double salarioLiquido = salarioBruto - desconto;

            Console.WriteLine($"Salário Bruto: {salarioBruto:F2}");
            Console.WriteLine($"Desconto: {desconto:F2}");
            Console.WriteLine($"Salário: {salarioLiquido:F2}");
            
           

        }
    }
}

// salarioBruto - desconto = salarioLiquido
// Até R$ 2.000    5 %
// De R$ 2.000,01 até R$ 4.000 10 %
// De R$ 4.000,01 até R$ 6.000 15 %
// Acima de R$ 6.000   20 %