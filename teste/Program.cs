using System;

namespace DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Magica mgc = new Magica();
            
            Console.Write("Valor 1: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor 1: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(mgc.somar(a,b));

            Console.WriteLine("teste");
        }
    }


    
}
