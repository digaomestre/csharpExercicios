using System;
using System.Globalization;
namespace calculaArea
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Entrada:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = Math.PI*Math.Pow(raio, 2);

            Console.WriteLine("A="+area.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
