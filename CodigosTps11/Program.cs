namespace CodigosTps11 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Informe sua data de nascimento: ");
            DateTime Nascimento = DateTime.Parse(Console.ReadLine());

            DateTime dataDehoje = DateTime.Now;

            DateTime aniversarioProx = new DateTime(
                dataDehoje.Year,
                Nascimento.Month,
                Nascimento.Day
            );

            if (aniversarioProx < dataDehoje) {

                aniversarioProx = aniversarioProx.AddYears(1);

            }

            TimeSpan diferenca = aniversarioProx - dataDehoje;

            int dias = diferenca.Days;

            Console.WriteLine($"Faltam {dias} dias para o seu próximo aniversário.");

        }
    }
}
