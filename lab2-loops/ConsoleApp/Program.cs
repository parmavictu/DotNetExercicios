using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Pares");
            for(int i = 1; i <= 10; i++)
            {
                if(i % 2 == 0) Console.Write(i + " ");
            }

            Console.WriteLine("");
            System.Console.WriteLine("Menores ou iguais a 5");
            int j=1;

            while( j<=10 )
            {
                if(j <=5) Console.Write(j + " ");
                j++;
            }


            Console.ReadKey();
        }
    }
}
