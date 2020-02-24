using System;
//Faça um programa que leia 5 números e informe o maior número.

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int greatestNumber=0;
            for(int i=1; i<=5; i++){
                Console.Write($"Digite o {i}º número: ");
                int.TryParse(Console.ReadLine(), out num);

                if(i==1) greatestNumber = num;
                if(num > greatestNumber) greatestNumber = num;
            }
            Console.WriteLine($"O maior número é : {greatestNumber}");
            Console.ReadKey();
        }
    }
}
