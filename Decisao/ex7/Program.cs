using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int greatest=0;
            int smaller =0;
            for(int i=1 ; i <= 3; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                int.TryParse(Console.ReadLine(), out int num);
                if(i==1)
                { 
                    greatest = num;
                    smaller = num;
                }
                if(num > greatest) greatest = num;
                if(num < smaller) smaller = num;
            }

            Console.WriteLine($"Maior número é: {greatest}");
            Console.WriteLine($"Menor número é: {smaller}");
            Console.ReadKey();
        }
    }
}
