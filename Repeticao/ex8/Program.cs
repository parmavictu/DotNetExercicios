using System;
//Faça um programa que leia 5 números e informe a soma e a média dos números.

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            double sum = 0;
            
            for(int i=1; i<=5; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                double.TryParse(Console.ReadLine(), out num);
                sum +=  num;
                
            }
            double average = sum / 5;
            Console.WriteLine($"A soma é : {sum}");
            Console.WriteLine($"A média é: {average}");
            Console.ReadKey();
        }
    }
}
