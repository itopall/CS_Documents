using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CodeFirst
{
    public class NorthwndContext : DbContext
    {
        public NorthwndContext() : base("name=NortwndConnectionString")
        {
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}
