using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
   public class ListaCarro
    {
        public static List<string> listaVeiculos()
        {
            List<string> marcaVeiculo = new List<string>();
            marcaVeiculo.Add("\r\nFIAT");
            marcaVeiculo.Add("CHEVROLET");
            marcaVeiculo.Add("NISSAN");
            marcaVeiculo.Add("HIUNDAY");
            marcaVeiculo.Add("WOLKSWAGEN\r\n");
            //foreach (var item in marcaVeiculo)
            //{
            //    Console.WriteLine(item);
            //}

           
               

                return marcaVeiculo;
            }

        
    }
}
