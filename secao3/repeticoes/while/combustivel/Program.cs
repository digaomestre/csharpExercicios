using System;

namespace combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Alcool 2.Gasolina 3.Diesel 4.Sair");
            int a = 0, g = 0, d = 0, cod;
            System.Console.WriteLine("Digite o codigo:");
            cod = int.Parse(Console.ReadLine());
            while (cod != 4)
            {
                if(cod == 1){
                    a++;
                }else if(cod == 2){
                    g++;
                }else if(cod == 3){
                    d++;
                }

                if(cod < 1 || cod > 4){
                    System.Console.WriteLine("codigo invalido!");
                    do
                    {
                        System.Console.WriteLine("Digite outro codigo:");
                        cod = int.Parse(Console.ReadLine());   
                    } while (cod < 1 || cod > 4);
                }else{
                    cod = int.Parse(Console.ReadLine()); 
                }
            }

            System.Console.WriteLine($"\n Alcool:{a} \n Gasolina{g} \n Diesel:{d} ");
        }
    }
}
