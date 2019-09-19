using MinhaTerceiraClasse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaTerceiraClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            
            carro.Cadastrar();
            Console.ReadKey();
        }        
    }
}
