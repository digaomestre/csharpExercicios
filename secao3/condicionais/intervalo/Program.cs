using System;
using System.Globalization;
namespace intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Verifica interlo.*********");
            Console.WriteLine("Digite o valor:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if(valor > 0 && valor <= 25){
                Console.WriteLine("[0 - 25]");
            }else if(valor <= 50){
                Console.WriteLine("[25 - 50]");
            }else if(valor <= 75){
                Console.WriteLine("[50 - 75]");
            }else if(valor <= 100){
                Console.WriteLine("[75 - 100]");
            }else{
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
