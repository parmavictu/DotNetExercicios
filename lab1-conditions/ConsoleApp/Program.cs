using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor de 1 a 100: ");
            int.TryParse(Console.ReadLine(), out int num);

            while( num < 1 || num > 100)
            {
                Console.Write("Valor é inválido para o sorteio. Por favor entre com um valor de 1 a 100: ");
                int.TryParse(Console.ReadLine(), out num);
            }

            if(num == 40 || num == 75 || num == 90) Console.WriteLine("Sortudo, ganhou um carro!!");
            else Console.WriteLine("Tente novamente, quem sabe você ganha!");

            Console.ReadKey();
        }
    }
}
