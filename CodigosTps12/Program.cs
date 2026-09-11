namespace CodigosTps12 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite a primeira data..: ");
            DateTime primeiraData = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda data..: ");
            DateTime segundaData = DateTime.Parse(Console.ReadLine());

            if (primeiraData > segundaData) {

                DateTime temp = primeiraData;
                primeiraData = segundaData;
                segundaData = temp;
            }

            TimeSpan diferenca = segundaData - primeiraData;

            int anos = segundaData.Year - primeiraData.Year;

            DateTime dataDpsDosanos = primeiraData.AddYears(anos);

            if (dataDpsDosanos > segundaData) {

                anos--;
                dataDpsDosanos = primeiraData.AddYears(anos);
            }

            int meses = 0;
            DateTime dataDpsDosmeses = dataDpsDosanos;

            while (dataDpsDosmeses.AddMonths(1) <= segundaData) {

                dataDpsDosmeses = dataDpsDosmeses.AddMonths(1);
                meses++;
            }

            int dias = (segundaData - dataDpsDosmeses).Days;

            Console.WriteLine($"diferença entre as datas é de {dias} dias, {meses} meses e {anos} anos.");

            Console.WriteLine($"diferença total é de {diferenca.Days} dias." );

        }
    }
}
