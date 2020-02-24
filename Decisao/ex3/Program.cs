using System;
//Faça um Programa que verifique se uma letra digitada é "F" ou "M". Conforme a letra escrever: F - Feminino, M - Masculino, Sexo Inválido.
namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu sexo(M/F):");
            char gender = char.ToUpper(Console.ReadLine()[0]);
            
            if(gender.Equals('M')) Console.WriteLine("M - Masculino");
            else if(gender.Equals('F')) Console.WriteLine("F - Feminino");
            else Console.WriteLine("Sexo Inválido");

            Console.ReadKey();

        }
    }
}
