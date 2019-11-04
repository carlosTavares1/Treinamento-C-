using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppSolucaoDois_04_11_19.Model
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Imovel> GetImovels { get; set; }
        public DbSet<Proprietario> GetProprietarios { get; set; }
        public DbSet<Usuario> GetUsuarios { get; set; }
    }
}
