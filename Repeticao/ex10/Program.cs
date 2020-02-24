using System;
//Faça um programa que receba dois números inteiros e gere os números inteiros que estão
//no intervalo compreendido por eles.
namespace ex10
{
    //Faça um programa que receba dois números inteiros e gere os números inteiros que estão no intervalo compreendido por eles.

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int.TryParse(Console.ReadLine(), out int num1);
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int num2);

            Console.WriteLine($"Os números de {num1} até {num2}: ");
            
            
            for(int i= num1 + 1; i<num2; i++){
                Console.Write($"{i} ");
            }          

            Console.ReadKey();
        }
    }
}
