using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;
namespace EntityClass.Controller
{
    public class PessoaController
    {
        //Realizo minha conexão com o banco de dados
        EntityContextDB contextDB = new EntityContextDB();

        public IQueryable //Aqui temos nossa primera interface com a classe 
                         //IQueryableessa classe contem varias funcionalidades
                        //prontas para usar igual ao banco de dados como os selects
            <Pessoa> //Definimos o tipo que irá retornar
            GetPessoas() //Damos um nome ao nosso metodo
        {
            return contextDB.ListaDePessoas; //retornamos nossa lista de pessoas
        }
        /// <summary>
        /// Método que adiciona pessoa no banco de dados
        /// </summary>
        /// <param name="item">Item pessoa</param>
        public void AddPessoa(Pessoa item)
        {
            contextDB//Nosso banco de dados
                .ListaDePessoas//Nossa tabela pessoa
                .Add(item);//Adicionamos o item

            contextDB.SaveChanges();
        }
    }
}
