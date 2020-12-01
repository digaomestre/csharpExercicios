using System;
using System.Globalization;
namespace formas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor de B: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor de C: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
        }
    }
}
