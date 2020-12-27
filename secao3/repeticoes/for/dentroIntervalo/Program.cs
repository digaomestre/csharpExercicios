using System;

namespace dentroIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            int c_in = 0, c_out = 0;
            Console.WriteLine("Digite a quantidade numeros:");
            int qtde = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtde; i++)
            {
                System.Console.WriteLine($"Digite o {i}º valores:");
                int val = int.Parse(Console.ReadLine());
                if(val > 9 && val < 21){
                    c_in++;
                }else
                {
                    c_out++;
                }
            }
            System.Console.WriteLine($"{c_in} in \n{c_out} out");
        }
    }
}
