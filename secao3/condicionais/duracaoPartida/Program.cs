using System;

namespace duracaoPartida
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] hora = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(hora[0]);
            int horaFinal = int.Parse(hora[1]);
            int duracao = 0;
            Console.WriteLine($"Inicial: {horaInicial}");
            Console.WriteLine($"Final: {horaFinal}");
            if(horaInicial < horaFinal){
                duracao = horaFinal - horaInicial;
            }else{
                duracao = (24 - (horaFinal + horaInicial)); 
            }

            Console.WriteLine($"Jogou durante:{duracao}");
        }
    }
}
