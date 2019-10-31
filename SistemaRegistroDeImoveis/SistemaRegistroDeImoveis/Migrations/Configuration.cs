namespace SistemaRegistroDeImoveis.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    
    internal sealed class Configuration : DbMigrationsConfiguration<SistemaRegistroDeImoveis.Models.ProprietarioContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SistemaRegistroDeImoveis.Models.ProprietarioContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Proprietarios.AddOrUpdate(new Models.Proprietario()
            {
                Nome = "Carlos",
                DataNascimento = DateTime.Parse("30/10/19"),
                Email = "cast.3@hotmail.com"
            });

            context.Imovels.AddOrUpdate(new Models.Imovel()
            {
                Logradouro = "Avenida",
                Bairro = "Maguari",
                Numero = "9",
                Complemento = "Próximo ao canteiro central",
                Municipio = "Ananindeua",
                Cep = "88145000"
            });

            context.SaveChanges();
        }
    }
}
