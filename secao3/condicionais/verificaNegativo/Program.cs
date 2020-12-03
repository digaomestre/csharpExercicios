using System;

namespace verificaNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro:");
            int num = int.Parse(Console.ReadLine());

            if(num >= 0){
                Console.WriteLine("NÃO NEGATIVO");
            }else{
                Console.WriteLine("NEGATIVO");
            }
        }
    }
}
