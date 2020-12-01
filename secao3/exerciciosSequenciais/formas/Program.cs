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

            double triangulo = a*c;
            double circulo = Math.PI*Math.Pow(c, 2);
            double trapezio = (a+b)*c/2;
            double quadrado = Math.Pow(b, 2);
            double retangulo = a*b;

            Console.WriteLine("TRIANGULO : "+triangulo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo : "+Circulo.ToString("F4", CultureInfo.InvariantCulture));
        }
    }

