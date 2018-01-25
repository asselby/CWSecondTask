using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFirst
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CustomerConfiguration> Customers {get;set;}
        public DbSet<OrderConfiguration> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new OrderDetailsConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public ApplicationDbContext(): base("name=entityFramework")
        {

        }
       
    }
}
