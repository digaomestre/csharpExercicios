using System;

namespace diferencaMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores de A B C e D");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int dif = a*b - c*d;

            Console.WriteLine($"Diferença: {dif}");
            
        }
    }
}
