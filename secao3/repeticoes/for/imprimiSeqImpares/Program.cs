using System;

namespace imprimiSeqImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Digite um numero: ");
            int x = int.Parse(Console.ReadLine());

            if(x > 1000){
                System.Console.WriteLine("o valor está fora de intervalo.");
            }else
            {
                for(int i = 0; i < x; i += 2){
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
