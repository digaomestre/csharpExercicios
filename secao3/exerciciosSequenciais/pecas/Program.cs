using System;
using System.Globalization;
namespace pecas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Codigo Peça:");
            int codigo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            int qtde1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor da peça: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Codigo Peça:");
            int codigo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            int qtde2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor da peça: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = (valor1*qtde1)+(valor2*qtde2);

            Console.WriteLine("Valor a pagar: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
