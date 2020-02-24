using System;
//Desenvolva um gerador de tabuada, capaz de gerar a tabuada de qualquer número inteiro entre 1 a 10. O usuário deve informar de qual numero ele deseja ver a tabuada. A saída deve ser conforme o exemplo abaixo:

namespace ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quer saber a tabuada de: ");
            int.TryParse(Console.ReadLine(), out int num);
            
            Console.WriteLine($"Tabuada de {num}");
            for(int i=1 ; i<=10; i++)
            {
                Console.WriteLine($"{num} x {i} = { i * num }");
            }
            Console.ReadKey();
        }
    }
}
