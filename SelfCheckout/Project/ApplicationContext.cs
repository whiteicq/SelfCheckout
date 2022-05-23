using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SelfCheckout
{
    class ApplicationContext : DbContext
    {

        public ApplicationContext() : base("DefaultConnection") { }
        public DbSet<Product> Products { get; set; }
    }
}
