using System;
//Faça um Programa que peça dois números e imprima o maior deles.
namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int.TryParse(Console.ReadLine(), out int num1);

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int num2);

            if(num1 > num2) Console.WriteLine($"{num1} é maior que {num2}");
            else if(num1 == num2) Console.WriteLine($"{num1} e {num2} são iguais");
            else Console.WriteLine($"{num2} é maior que {num1}");

            Console.ReadKey();
        }
    }
}
