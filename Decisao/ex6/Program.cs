using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int greatest=0;
            for(int i=1 ; i <= 3; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                int.TryParse(Console.ReadLine(), out int num);
                if(i==1) greatest = num;
                if(num > greatest) greatest = num;
            }

            Console.WriteLine($"Maior número é: {greatest}");
            Console.ReadKey();
        }
    }
}
