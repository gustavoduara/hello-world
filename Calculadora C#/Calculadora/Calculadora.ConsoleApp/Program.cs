namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_____________________________");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("_____________________________");

            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("S - Sair");

            Console.WriteLine("Escolha uma opção");

            string opção = Console.ReadLine().ToUpper(); //s // S

            //Estrutura de decisão(se/senao)
            if (opção == "S"){

            }
                return;



            Console.Write("Digite o primeiro número: ");

            String primeironumerostring Console.WriteLine();

            int primeironumero = Convert.ToInt32(primeironumerostring);

            Console.WriteLine("Digite o segundo número");
            string segundonumerostring = Console.ReadLine();
            int segundonumeros = Convert.ToInt32(segundonumerostring);

            int resultado = primeironumero + segundonumeros;



            Console.WriteLine(resultado);

            Console.WriteLine();
        }
    }
}
