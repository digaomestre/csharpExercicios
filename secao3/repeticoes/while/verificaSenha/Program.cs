using System;

namespace verificaSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2020;
            Console.WriteLine("digite a senha");
            int v = int.Parse(Console.ReadLine());
            while(v != senha){
                Console.WriteLine("Senha invalida!!!");
                Console.WriteLine("Digite outra senha:");
                v = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
