using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleMigration.Model;

namespace ConsoleMigration
{
    class Program
    {
        static MigrationContext db = new MigrationContext();
        static void Main(string[] args)
        {
            //Iniciamos nossa base de dados
            db.Usuarios.ToList().ForEach(x => Console.WriteLine(x.Nome));

            Console.ReadKey();

            //Enable-Migrations    -> uso este comando para habilitar o migrations
            //Update-DataBase  -> uso este comando para atualizar a base de dados
            //Add-Migration  -> uso este comando para adicionar um novo migration
            //Update-DataBase -Target AddEmailUsuario  -> uso este comando para voltar em algum migrations que eu queira
        }
    }
}
