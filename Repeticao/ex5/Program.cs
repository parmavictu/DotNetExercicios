using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite a primeira população: ");
                double.TryParse(Console.ReadLine(), out double populationA);

                Console.Write("Digite a taxa de crescimento da primeira população: ");
                double.TryParse(Console.ReadLine(), out double pA);

                Console.Write("Digite a segunda população: ");
                double.TryParse(Console.ReadLine(), out double populationB);

                Console.Write("Digite a taxa de crescimento da segunda população: ");
                double.TryParse(Console.ReadLine(), out double pB);

                int count = 0;

                while (populationA < populationB)
                {
                    populationA += populationA * (pA / 100);
                    populationB += populationB * (pB / 100);
                    count++;
                }
                Console.WriteLine($"O número de anos necessários é: {count}");
                
                Console.WriteLine("Quer continuar?(S/N): ");
                char end = char.ToUpper(Console.ReadLine()[0]);
                if (!end.Equals('S')) break; 
            }
            Console.ReadKey();
        }
    }
}
