namespace CodigosTps {
    internal class Program {
        static void Main(string[] args) {

           
            
            
            

            Console.WriteLine("Digite seu Nome completo: ");
            String nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu telefone: ");
            String telefone = Console.ReadLine();

            Console.WriteLine("Digite seu e-mail de usuario: ");
            String email = Console.ReadLine();


            Console.WriteLine("===== DADOS DO USUARIO CADASTRADO =====");

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Telefone: " + telefone);
            Console.WriteLine("E-mail: " + email);

            


        }
    }
}
