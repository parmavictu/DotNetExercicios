using System;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int.TryParse(Console.ReadLine(), out int num1);
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int num2);
            Console.Write("Digite o terceiro número: ");
            int.TryParse(Console.ReadLine(), out int num3);


            if(num1>num2 && num1> num3)
            {
                if(num2>num3)
                {
                    Console.WriteLine($"{num1}, {num2}, {num3}");
                }
                else
                {
                    Console.WriteLine($"{num1}, {num3}, {num2}");
                }
            }
            else if(num2> num3 && num2 > num1)
            {
                if(num1>num3)
                {
                    Console.WriteLine($"{num2}, {num1}, {num3}");
                }
                else
                {
                    Console.WriteLine($"{num2}, {num3}, {num1}");
                
                }
            }
            else{
                if(num1>num2)
                {
                    Console.WriteLine($"{num3}, {num1}, {num2}");
                }
                else
                {
                    Console.WriteLine($"{num3}, {num2}, {num1}");
                
                }
            }
            Console.ReadKey();
        }
    }
}
