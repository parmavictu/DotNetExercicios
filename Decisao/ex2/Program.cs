using System;
//Faça um Programa que peça um valor e mostre na tela se o valor é positivo ou negativo.
namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número: ");
            int.TryParse(Console.ReadLine(), out int num);

            if(num >= 0) Console.WriteLine("positivo");
            else Console.WriteLine("negativo");

            Console.ReadKey();

        }
    }
}
;