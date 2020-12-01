using System;
using System.Globalization;

namespace funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código do funcionário:");
            int codFunc = int.Parse(Console.ReadLine());
            Console.WriteLine("Horas trabalhadas: ");
            int horasTrab = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor da hora:");
            double valHoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = horasTrab*valHoras;

            Console.WriteLine($"Codigo: {codFunc}");
            Console.WriteLine("Salário: R$ "+salario.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
