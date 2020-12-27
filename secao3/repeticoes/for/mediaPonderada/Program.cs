using System;
using System.Globalization;

namespace mediaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite a quantidade de testes:");
            int qtde = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os valores:");
            for (int i = 0; i < qtde; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                double v1 = double.Parse(v[0], CultureInfo.InvariantCulture);
                double v2 = double.Parse(v[1], CultureInfo.InvariantCulture);
                double v3 = double.Parse(v[2], CultureInfo.InvariantCulture);

                double mediaP = (v1*2.0+v2*3.0+v3*5.0)/10.0;

                System.Console.WriteLine(mediaP.ToString("F1", CultureInfo.InvariantCulture)); 
            }
        }
    }
}
