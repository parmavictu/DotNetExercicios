using System;
using xpto;
namespace sandbox//namespace é para agrupar objeto / classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Batman b = new Batman();
            Miranha m = new Miranha();

            b.poder = "dinheiro";
            b.QG = "bat-caverna";
            b.uniforme = "Morcego";
            b.trilhaSonora = "nananaã";


            m.poder = "Teia";
            m.QG = "casa da tia may";
            m.trilhaSonora = "Spider man spider man";
            m.uniforme = "teia vermelha e azul";

            Console.WriteLine(m.Escrever());
            Console.WriteLine(b.Escrever());
            Console.ReadKey();
        }
    }
}
