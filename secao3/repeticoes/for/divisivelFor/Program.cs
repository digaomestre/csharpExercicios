using System;
using System.Globalization;

namespace divisivelFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade:");
            int qtde = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite os valores:");
            for (int i = 0; i < qtde; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                double v1 = double.Parse(v[0], CultureInfo.InvariantCulture);
                double v2 = double.Parse(v[1], CultureInfo.InvariantCulture);

                if(v2 == 0){
                    System.Console.WriteLine("Divisão impossivel");
                }else
                {
                    double total = v1/v2;
                    System.Console.WriteLine(total.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
