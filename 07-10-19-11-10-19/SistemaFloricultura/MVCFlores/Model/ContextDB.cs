using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFlores.Model
{
    public class ContextDB : DbContext
    {
        public DbSet<Flor> Flors { get; set; }
    }
}
