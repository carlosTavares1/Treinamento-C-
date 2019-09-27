using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
    public class SistemaCarrosContext
    {
        /// <summary>
        /// Esta propriedade fornece acesso aos dados
        /// </summary>
        private List<Carro> ListaDeCarros { get; set; }
        /// <summary>
        /// Este construtor possibilita o acesso a massa de dados
        /// </summary>
        public SistemaCarrosContext()
        {
            ListaDeCarros = new List<Carro>();
            ListaDeCarros.Add(new Carro()
            {
                Id = 1,
                Marca = "Fiat",
                Modelo = "Palio",
                Ano = 2010,
                Cilindradas = 150,
                Portas = 2
            });
            ListaDeCarros.Add(new Carro()
            {
                Id = 2,
                Marca = "Hyundai",
                Modelo = "HB20",
                Ano = 2015,
                Cilindradas = 180,
                Portas = 4
            });
            ListaDeCarros.Add(new Carro()
            {
                Id = 3,
                Marca = "Mitsubichi",
                Modelo = "Pajero",
                Ano = 2018,
                Cilindradas = 200,
                Portas = 4
            });
            ListaDeCarros.Add(new Carro()
            {
                Id = 4,
                Marca = "Nissan",
                Modelo = "Versa",
                Ano = 2016,
                Cilindradas = 210,
                Portas = 2
            });
            ListaDeCarros.Add(new Carro()
            {
                Id = 5,
                Marca = "Hyundai",
                Modelo = "Veloster",
                Ano = 2020,
                Cilindradas = 245,
                Portas = 3
            });
            ListaDeCarros.Add(new Carro()
            {
                Id = 6,
                Marca = "Wolkswagen",
                Modelo = "Gol",
                Ano = 2009,
                Cilindradas = 143,
                Portas = 4
            });
            ListaDeCarros.Add(new Carro()
            {
                Id = 7,
                Marca = "Honda",
                Modelo = "Civic",
                Ano = 2005,
                Cilindradas = 169,
                Portas = 4
            });
            ListaDeCarros.Add(new Carro()
            {
                Id = 8,
                Marca = "Jac",
                Modelo = "J5",
                Ano = 2021,
                Cilindradas = 186,
                Portas = 4
            });
            ListaDeCarros.Add(new Carro()
            {
                Id = 9,
                Marca = "Jeep",
                Modelo = "Renegade",
                Ano = 2019,
                Cilindradas = 171,
                Portas = 4
            });
            ListaDeCarros.Add(new Carro()
            {
                Id = 10,
                Marca = "Mercedes",
                Modelo = "Benz",
                Ano = 2010,
                Cilindradas = 260,
                Portas = 4
            });
        }
        /// <summary>
        /// Esta propriedade retorna a lista que está no private
        /// </summary>
        public List<Carro> ListaPublicaDeCarro { get{ return ListaDeCarros; } }
    }
}
