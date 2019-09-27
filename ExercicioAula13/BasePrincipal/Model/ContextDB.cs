using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasePrincipal.Model
{
    public class ContextDB
    {
        public List<Veiculo> ListaDeVeiculos { get; set; }

        public ContextDB()
        {
            ListaDeVeiculos = new List<Veiculo>();

            ListaDeVeiculos.Add(new Veiculo()
            {
                Id = 1,
                Nome = "Risus Company",
                Valor = 7200,
                Quantidade = 18,
                DataDaVenda = DateTime.Parse("29/01/2019")
            });
            ListaDeVeiculos.Add(new Veiculo()
            {
                Id = 2,
                Nome = "Risus Associates",
                Valor = 9961,
                Quantidade = 4,
                DataDaVenda = DateTime.Parse("10/02/2019")
            });
            ListaDeVeiculos.Add(new Veiculo()
            {
                Id = 3,
                Nome = "Et Libero Proin Foundation",
                Valor = 8710,
                Quantidade = 17,
                DataDaVenda = DateTime.Parse("24/01/2019")
            });
            ListaDeVeiculos.Add(new Veiculo()
            {
                Id = 4,
                Nome = "Cursus El Ltd",
                Valor = 9010,
                Quantidade = 17,
                DataDaVenda = DateTime.Parse("26/10/2019")
            });
            ListaDeVeiculos.Add(new Veiculo()
            {
                Id = 5,
                Nome = "Odio Etiam Ligula Company",
                Valor = 5245,
                Quantidade = 8,
                DataDaVenda = DateTime.Parse("16/02/2019")
            });
            ListaDeVeiculos.Add(new Veiculo()
            {
                Id = 6,
                Nome = "Eu Nibh Inc.",
                Valor = 7922,
                Quantidade = 9,
                DataDaVenda = DateTime.Parse("27/06/2019")
            });
            ListaDeVeiculos.Add(new Veiculo()
            {
                Id = 7,
                Nome = "Tellus Limited",
                Valor = 7294,
                Quantidade = 7,
                DataDaVenda = DateTime.Parse("26/01/2019")
            });
            ListaDeVeiculos.Add(new Veiculo()
            {
                Id = 8,
                Nome = "Imperdiet PC",
                Valor = 8305,
                Quantidade = 5,
                DataDaVenda = DateTime.Parse("06/09/2019")
            });
            ListaDeVeiculos.Add(new Veiculo()
            {
                Id = 9,
                Nome = "Elit Inc.",
                Valor = 5398,
                Quantidade = 18,
                DataDaVenda = DateTime.Parse("09/06/2019")
            });
            ListaDeVeiculos.Add(new Veiculo()
            {
                Id = 9,
                Nome = "Elit Inc.",
                Valor = 5398,
                Quantidade = 18,
                DataDaVenda = DateTime.Parse("09/06/2019")
            });
        }
    }
}
