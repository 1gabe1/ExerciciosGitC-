namespace CodigosTps10 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Informe sua data de Nascimento: ");

            DateTime dataNas = DateTime.Parse(Console.ReadLine());

            DateTime datahoje = DateTime.Now;

            int anos = datahoje.Year - dataNas.Year;

            if (dataNas.Month > datahoje.Month) {
                
                anos--;

            }
            else if (dataNas.Month == datahoje.Month) {

                if (dataNas.Day > datahoje.Day) {

                    anos--;
                   

                }
               
                
            }

            int meses = datahoje.Month - dataNas.Month;

            if (dataNas.Month > datahoje.Month) {
                meses = meses + 12;

            }

            if (dataNas.Day > datahoje.Day ) {
                meses--;
            
            }

            int dias = datahoje.Day - dataNas.Day;

            if (dias < 0) {

                int mesAnterior = datahoje.Month - 1;

                if (mesAnterior == 0) {
                    mesAnterior = 12;
                }

                int anoMesAnterior = datahoje.Year;

                if (datahoje.Month == 1) {
                    anoMesAnterior--;
                }

                dias = dias + DateTime.DaysInMonth(anoMesAnterior, mesAnterior);
            }

            Console.WriteLine($"Você está com {anos} anos, {meses} meses e {dias} dias.");


        }
    }
}
