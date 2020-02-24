using System;
//As Organizações Tabajara resolveram dar um aumento de salário aos seus colaboradores e lhe contraram para desenvolver o programa que calculará os reajustes.
//Faça um programa que recebe o salário de um colaborador e o reajuste segundo o seguinte critério, baseado no salário atual:
//salários até R$ 280,00 (incluindo) : aumento de 20%
//salários entre R$ 280,00 e R$ 700,00 : aumento de 15%
//salários entre R$ 700,00 e R$ 1500,00 : aumento de 10%
//salários de R$ 1500,00 em diante : aumento de 5% Após o aumento ser realizado, informe na tela:
//o salário antes do reajuste;
//o percentual de aumento aplicado;
//o valor do aumento;
//o novo salário, após o aumento.
namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite seu salário: ");
            double.TryParse(Console.ReadLine(), out double wage);

            double pIncrease=0;
            double newWage=wage;

            if(wage <280) pIncrease = 0.2;
            else if(wage >=280 && wage <700) pIncrease = 0.15;
            else if(wage>=700 && wage <1500) pIncrease =0.1;
            else pIncrease = 0.05;

            double increase = pIncrease * wage;
            newWage +=  increase;

            Console.WriteLine("O salário antes do reajuste: " + wage.ToString("C"));
            Console.WriteLine($"O percentual de aumento aplicado: {pIncrease * 100}%");
            Console.WriteLine("O valor de aumento: " + increase.ToString("C")) ;
            Console.WriteLine($"O novo salário, após o aumento: " + newWage.ToString("C"));

            Console.ReadKey();
        }
    }
}
