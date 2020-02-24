using System;

namespace ex10
{
    //a um Programa que pergunte em que turno você estuda. Peça para digitar M-matutino ou V-Vespertino ou N- Noturno. Imprima a mensagem "Bom Dia!",
    //"Boa Tarde!" ou "Boa Noite!" ou "Valor Inválido!", conforme o caso.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual turno você estuda? ");
            char choice = char.ToUpper(Console.ReadLine()[0]);


            if(choice.Equals('M')) Console.WriteLine("Bom dia!");
            else if(choice.Equals('V')) Console.WriteLine("Boa tarde!");
            else if(choice.Equals('N')) Console.WriteLine("Boa noite!");
            else Console.WriteLine("Valor inválido");

            Console.ReadKey();
        }
    }
}
