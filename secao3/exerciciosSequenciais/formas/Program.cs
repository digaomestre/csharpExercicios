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

            double triangulo = a*c/2;
            double circulo = Math.PI*Math.Pow(c, 2);
            double trapezio = (a+b)*c/2;
            double quadrado = Math.Pow(b, 2);
            double retangulo = a*b;


            Console.WriteLine("TRIANGULO : "+triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO : "+circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO : "+ trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO : "+ quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO : "+ retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }

}