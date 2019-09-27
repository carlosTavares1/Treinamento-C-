using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRelatorioCarros.Model
{
    public class RelatorioCarrosContext
    {
        /// <summary>
        /// Nossa massa de dados interna
        /// </summary>
        private List<Venda> ListaDeVendas { get; set; }
        /// <summary>
        /// Construtor que prepara nossa massa de dados
        /// </summary>
        public RelatorioCarrosContext()
        {
            //Criamos nossa lista de vendas em memoria
            ListaDeVendas = new List<Venda>();

            ListaDeVendas.Add(new Venda()
            {
                Id = 1,
                Carro = "Elantra",
                Valor = 2000,
                Quantidade = 5,
                Data = DateTime.Parse("05/03/2019")
            });
            ListaDeVendas.Add(new Venda()
            {
                Id = 2,
                Carro = "Gol",
                Valor = 4000,
                Quantidade = 8,
                Data = DateTime.Parse("20/03/2019")
            });
            ListaDeVendas.Add(new Venda()
            {
                Id = 3,
                Carro = "Palio",
                Valor = 6000,
                Quantidade = 10,
                Data = DateTime.Parse("10/01/2019")
            });
        }
        /// <summary>
        /// Propriedade sem filtro
        /// </summary>
        public List<Venda> ListaVendaPublica { get { return ListaDeVendas; } }
    }
}
