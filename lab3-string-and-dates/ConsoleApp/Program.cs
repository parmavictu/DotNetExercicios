using System;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problema 1: ");

            Console.Write("Digite a frase: ");
            string problemDotNet = Console.ReadLine();

            string dotNetWord = changeDotNet(problemDotNet);
            Console.WriteLine(dotNetWord);


            Console.WriteLine("Problema 2: ");
            Console.Write("digite o valor de entrada: ");
            int.TryParse(Console.ReadLine(), out int value);

            string virgulaProblem = addNumbersAndVirgula(value);
            Console.WriteLine(virgulaProblem);

            Console.WriteLine("Problema 3: ");

            Console.Write("Digite a data no formato DD/MM/AAAA HH:MM:SS e pressione enter:  ");
            string problemDate1 = Console.ReadLine();

            string date1Problem = EditingDate(problemDate1);
            Console.WriteLine(date1Problem);


            Console.WriteLine("Problema 4: ");

            Console.Write("Digite a data no formato DD/MM/AAAA HH:MM:SS e pressione enter:  ");
            string problemDate2 = Console.ReadLine();

            string date2Problem = Addingtime(problemDate2);
            Console.WriteLine(date2Problem);



            Console.ReadKey();
        }

        private static string Addingtime(string problemDate2)
        {
            DateTime dt =  DateTime.Parse(problemDate2 );
            return dt.AddDays(1).AddHours(4).AddMinutes(30).ToString("dd/MM/yyyy HH:mm:ss");
        }

        private static string EditingDate(string problemDate1)
        {
            DateTime dt =  DateTime.Parse(problemDate1 );
            return dt.ToString("dd/MM/yyyy HH:mm dddd, dd 'de' MMMM 'de' yyyy");
        }

        private static string addNumbersAndVirgula(int value)
        {
            StringBuilder sb = new StringBuilder();
            
            for(int i =value ; i<= value + 9; i++ ){
                sb.Append(i);
                if( i != value +9) sb.Append(",");
            }
            return sb.ToString();
        }

        private static string changeDotNet(string v)
        {
            var newDot = v.ToUpper().Replace("DOT ", ".");
            return newDot;
        }

        
    }
}
