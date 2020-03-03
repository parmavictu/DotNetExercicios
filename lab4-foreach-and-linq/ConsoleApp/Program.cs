
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class Compra
    {
        public string Cliente { get; set; }
        public decimal Valor { get; set; }
        public bool PagamentoRealizado { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var compras = new List<Compra>
            {
                new Compra { Valor = 20, PagamentoRealizado = true , Cliente = "João" },
                new Compra { Valor = 10, PagamentoRealizado = true , Cliente = "Maria" },
                new Compra { Valor = 80, PagamentoRealizado = false, Cliente = "Tereza" },
                new Compra { Valor = 30, PagamentoRealizado = true , Cliente = "José" },
                new Compra { Valor = 10, PagamentoRealizado = false, Cliente = "João" },
                new Compra { Valor = 20, PagamentoRealizado = true , Cliente = "João" },
                new Compra { Valor = 20, PagamentoRealizado = false, Cliente = "Tereza" },
                new Compra { Valor = 40, PagamentoRealizado = true, Cliente = "Maria" },
                new Compra { Valor = 30, PagamentoRealizado = true , Cliente = "João" },
                new Compra { Valor = 10, PagamentoRealizado = false, Cliente = "Tereza" }
            };

            Console.WriteLine($"Valor total a receber: {ValorTotalAReceber(compras)}");
            Console.WriteLine($"Devedores: {string.Join(", ", ClientesDevedores(compras))}");
            Console.ReadKey();
        }

        // Soma o valor de todas compras não pagas.
        // Resultado esperado: 120
        private static decimal ValorTotalAReceber(List<Compra> compras)
        {
            //return compras.Where(x => !x.PagamentoRealizado)
                            //.Sum(x => x.Valor);
            decimal sum=0;
            foreach (var item in compras)
            {
                if(!item.PagamentoRealizado) sum += item.Valor;
            }
            return sum;
        }

        // Seleciona os nomes dos clientes que têm compras não pagas.
        // Resultado esperado: Tereza, João
        private static IEnumerable<string> ClientesDevedores(List<Compra> compras)
        {
            

            //foreach (var compra in compras)
            //{
              //  if (!compra.PagamentoRealizado)
                //{
                  //  if (!devedores.Contains(compra.Cliente))
                    //{
                      //  devedores.Add(compra.Cliente);
                    //}
                //}
            //}
            return compras.Where(x => !x.PagamentoRealizado).Select(x => x.Cliente).Distinct();

            
        }
    }
}