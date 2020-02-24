using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a letra: ");
            char letter = char.ToUpper(Console.ReadLine()[0]);


            if(letter.Equals('A') || letter.Equals('E') || letter.Equals('I')
             || letter.Equals('O') || letter.Equals('U') ) Console.WriteLine("Vogal");
            else Console.WriteLine("Consoante");

            Console.ReadKey();
        }
    }
}
