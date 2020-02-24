using System;

namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Digite o primeiro número: ");
            int.TryParse(Console.ReadLine(), out int num1);
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int num2);

            Console.WriteLine($"Os números de {num1} até {num2}: ");
            
        
            for(int i= num1; i<=num2; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }          
            Console.WriteLine("");
            Console.WriteLine($"A soma entre os números é {sum}");
            Console.ReadKey();
        }
    }
}
