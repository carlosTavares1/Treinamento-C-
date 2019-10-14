using RevisandoEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisandoEntity.Controller;

namespace AplicacaoVisual
{
    class Program
    {
        //1 - Setar a aplicação visual para startar o projeto
        //2 - Vamos adicionar entityframework ao nosso projeto console
        //3 - Colocar em nosso using o system.data.entity
        //4 - Adicionar a referenciada nossa classlibrary

        //static CervejaContextDB cerveja = new CervejaContextDB();
        static CervejaController cerveja = new CervejaController();
        static void Main(string[] args)
        {
            //cerveja.Cervejas.Add(new Cerveja() { Nome = "Golimar" });

            //cerveja.SaveChanges();

            //cerveja.Cervejas.ToList<Cerveja>().ForEach(x => Console.WriteLine(x.Nome));
            cerveja.AddCerveja(new Cerveja()
            {
                Nome = "cerveja skol"
            });

            cerveja.GetCervejas().ToList<Cerveja>().ForEach(x => Console.WriteLine(x.Nome));

            Console.ReadKey();
        }
    }
}
