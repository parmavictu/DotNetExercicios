using System;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            double lessExpensive = 0;
            string bestProduct = "";
            for(int i=1 ; i <= 3; i++)
            {
                Console.Write("Nome do produto: ");
                string name = Console.ReadLine();
                Console.Write($"Digite o valor do {i}º produto: ");
                double.TryParse(Console.ReadLine(), out double price);
                if(i==1)
                {
                    lessExpensive = price;
                    bestProduct = name;
                } 
                if(price < lessExpensive)
                {
                    lessExpensive = price;
                    bestProduct = name;
                } 
            }

            Console.WriteLine($"O produto mais barato é {bestProduct}, com valor de " + lessExpensive.ToString("C"));
            Console.ReadKey();
        }
    }
}
