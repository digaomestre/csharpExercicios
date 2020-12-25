using System;

namespace quadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as coordenadas (x, y)");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            while (x != 0 && y != 0)
            {
                if(x > 0 && y > 0){
                    Console.WriteLine("Primeiro");
                }else if(x < 0 && y >0){
                    Console.WriteLine("Segundo");
                }else if(x < 0 && y < 0){
                    Console.WriteLine("Terceiro");
                }else{
                    Console.WriteLine("Quarto");
                }
                Console.WriteLine("Digite as coordenadas(x, y)");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }

        }
    }
}
