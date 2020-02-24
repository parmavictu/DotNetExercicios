using System;
//Faça um programa para a leitura de duas notas parciais de um aluno. O programa deve calcular a média alcançada por aluno e apresentar:
//A mensagem "Aprovado", se a média alcançada for maior ou igual a sete;
//A mensagem "Reprovado", se a média for menor do que sete;
//A mensagem "Aprovado com Distinção", se a média for igual a dez.
namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota da NP1: ");
            double.TryParse(Console.ReadLine(), out double np1);

            Console.Write("Digite a nota da NP2: ");
            double.TryParse(Console.ReadLine(), out double np2);

            double average = (np1 + np2) / 2;

            if(average == 10 ) Console.WriteLine("Aprovado com Distinção");
            else if(average >=7) Console.WriteLine("Aprovado");
            else Console.WriteLine("Reprovado");
            
            Console.ReadKey();

        }
    }
}
