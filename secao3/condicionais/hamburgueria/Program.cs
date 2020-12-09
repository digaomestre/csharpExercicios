using System;
using System.Globalization;
namespace hamburgueria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindos a humburgueir do papai!");
            Console.WriteLine("Menu - Opções: ");
            Console.WriteLine("1 - Cachorro Quente R$ 4.00");
            Console.WriteLine("2 - X - Salada R$ 4.50");
            Console.WriteLine("3 - X - Frango R$ 5.00");
            Console.WriteLine("4 - Torrada Simples R$ 2.00");
            Console.WriteLine("5 - Refrigerante R$ 1.00");

            Console.WriteLine("*********************************");

            Console.WriteLine("Digite o código do produto e quantidade: ");
            String[] produtos = Console.ReadLine().Split(';');
            int codigo = int.Parse(produtos[0]);
            int qtde = int.Parse(produtos[1]);
            double total = 0;

            switch(codigo){
                case 1:
                    total = 4.00*qtde;
                    break;
                case 2:
                    total = 4.50*qtde;
                    break;
                case 3:
                    total = 5.00*qtde;
                    break;
                case 4:
                    total = 2.00*qtde;
                    break;
                case 5:
                    total = 1.00*qtde;
                    break;
                default:
                    Console.WriteLine("Código invalido.");
                    break;
            }

            Console.WriteLine($"Total: R$ {total.ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}
