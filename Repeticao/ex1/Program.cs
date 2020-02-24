using System;


//Faça um programa que peça uma nota, entre zero e dez.
//Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.
namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite Sua nota(entre 0 e 10): ");
            double nota = Convert.ToDouble(Console.ReadLine());

            while( nota < 0 || nota > 10 )
            {
                Console.WriteLine("A nota digitada está fora dos padrões, por favor digite novamente!");

                Console.Write("Digite Sua nota(entre 0 e 10): ");
                nota = Convert.ToDouble(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
