using System;

namespace multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite B: ");
            int b = int.Parse(Console.ReadLine());

            if(a%b==0 || b%a==0){
                Console.WriteLine("multiplos");
            }else{
                Console.WriteLine("Não Multiplos");
            }
        }
    }
}
