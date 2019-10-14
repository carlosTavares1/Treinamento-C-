using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContext
    {
        /// <summary>
        /// Esta propriedade foi declarada para servir de lista de cerveja
        /// </summary>
        public List<Cerveja> ListaDeCerveja { get; set; }
        /// <summary>
        /// Esta propriedade foi criada para permitir a inserção de informações novas
        /// </summary>
        public Cerveja NovoItem { get; set; }
        /// <summary>
        /// Este construtor armazena algumas informações declaradas na lista
        /// </summary>
        public SistemaCervejaContext()
        {
            ListaDeCerveja = new List<Cerveja>();

            ListaDeCerveja.Add(new Cerveja()
            {
                Id = 1,
                Nome = "Skol",
                Litros = 0.6,
                Alcool = 4.5,
                Valor = 2.5
            });
            ListaDeCerveja.Add(new Cerveja()
            {
                Id = 2,
                Nome = "Budweiser",
                Litros = 0.25,
                Alcool = 6.5,
                Valor = 3.75
            });
            ListaDeCerveja.Add(new Cerveja()
            {
                Id = 3,
                Nome = "Corona",
                Litros = 0.68,
                Alcool = 12.3,
                Valor = 5.2
            });
            ListaDeCerveja.Add(new Cerveja()
            {
                Id = 4,
                Nome = "Brahma",
                Litros = 0.5,
                Alcool = 16.8,
                Valor = 8.99
            });
            ListaDeCerveja.Add(new Cerveja()
            {
                Id = 5,
                Nome = "Stella Artois",
                Litros = 0.125,
                Alcool = 30.4,
                Valor = 24.6
            });
        }
    }
}
