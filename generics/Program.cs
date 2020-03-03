using System;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MinhaClasseGenerica<string> g = new MinhaClasseGenerica<string>();
            g.Add("A string");
            Console.WriteLine(g.Get());
            Console.ReadKey();
        }
    }
}
