using System;
using System.Globalization;
namespace saidaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
           string Produto1 = "Computador";
           string Produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{Produto1}, cujo preço é {preco1}");
            Console.WriteLine($"{Produto2}, cujo preço é {preco2}");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine($"Medida com 8 casas decimais {medida:F8}");
            Console.WriteLine($"Arrendondado(Três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture:" +medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
