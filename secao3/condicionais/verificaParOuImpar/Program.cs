using System;

namespace verificaParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if(num%2 == 0){
                Console.WriteLine("Par");
            }else{
                Console.WriteLine("Impar");
            }
        }
    }
}
