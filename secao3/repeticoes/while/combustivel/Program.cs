﻿using System;

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
                switch (cod)
                {
                    case 1:
                        a++;
                        break;
                    case 2:
                        g++;
                        break;
                    case 3:
                        d++;
                        break;
                    case 4:
                        break;
                    default:
                        System.Console.WriteLine("codigo invalido!");
                        do
                        {
                            System.Console.WriteLine("Digite outro codigo");
                            cod = Console.ReadLine();
                        } while (cod < 1 || cod > 4);
                        break;

                }
            }
        }
    }
}
