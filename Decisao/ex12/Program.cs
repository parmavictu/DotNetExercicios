using System;

namespace ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Horas trabalhadas: ");
            int.TryParse(Console.ReadLine(),out int hours);

            Console.Write("Valor por hora: ");
            double.TryParse(Console.ReadLine(), out double value);

            double wageTotal = hours * value;
            double ir=0;
            if(wageTotal > 900 && wageTotal <=1500) ir = 0.05;
            else if(wageTotal > 1500 && wageTotal <= 2500) ir = 0.1;
            else if(wageTotal > 2500) ir = 0.2; 

            double irTotal = ir * wageTotal;
            double inss = 0.1 * wageTotal;
            double fgts = 0.11 * wageTotal;
            double totalDiscount = irTotal + inss;
            double newWage  = wageTotal - totalDiscount;

            Console.WriteLine($"Salário Bruto: ({hours} * {value}) : " + wageTotal.ToString("C"));
            Console.WriteLine($"(-) IR ({ir*100}%) : " + irTotal.ToString("C"));
            Console.WriteLine($"(-) INSS (10%) : " + inss.ToString("C"));
            Console.WriteLine("FGTS (11%) : " + fgts.ToString("C"));
            Console.WriteLine("Total de descontos : " + totalDiscount.ToString("C"));
            Console.WriteLine("Salário Liquido : " + newWage.ToString("C"));

            Console.ReadKey();




        }
    }
}
