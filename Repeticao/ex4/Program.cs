using System;
//Supondo que a população de um país A seja da ordem de 80000 habitantes com uma taxa anual de crescimento de 3%
//e que a população de B seja 200000 habitantes com uma taxa de crescimento de 1.5%. Faça um programa que
//calcule e escreva o número de anos necessários para que a população do país A ultrapasse ou iguale 
//a população do país B, mantidas as taxas de crescimento.
namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 80000;
            double b = 200000;
            int count = 0;

            while (a < b)
            {
                a += a * 0.03;
                b += b * 0.015;
                count++;
            }
            Console.WriteLine($"O número de anos necessários é: {count}");
            Console.ReadKey();
        }
    }
}
