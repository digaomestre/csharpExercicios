using System;

namespace verificaMaisVelho
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas p1 = new Pessoas();
            Pessoas p2 = new Pessoas();
            System.Console.WriteLine("Digite o nome e a idade da primeiro pessoa:");
            string[] d1 = Console.ReadLine().Split(' ');
            p1.nome = d1[0];
            p1.idade = int.Parse(d1[1]);
           System.Console.WriteLine("Digite o nome e a idade da segunda pessoa");
	    string[] d2 = Console.ReadLine().Split(' ');
            p2.nome = d2[0];
            p2.idade = int.Parse(d2[1]);

            if(p1.idade > p2.idade){
                Console.WriteLine($"{p1.nome} é mais velho");
            }else if(p1.idade < p2.idade){
                Console.WriteLine($"{p2.nome} é mais velho");
            }else{
                Console.WriteLine($"{p1.nome} e {p2.nome} tem a mesma idade");
            }
            
        }
    }
}
