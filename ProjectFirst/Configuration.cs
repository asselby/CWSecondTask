using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFirst
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            HasKey(p => p.Id);
        }
    }
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            HasKey(p => p.Id)
                .HasMany(p => p.Orders)
                .WithOptional(p => p.Customers)
                .HasForeignKey(p => p.CustomerId);
        }
    }

    public class OrderDetailsConfiguration : EntityTypeConfiguration<OrderDetails>
    {
        public OrderDetailsConfiguration()
        {
            HasKey(p => p.Id);
            HasMany(p => p.Orders)
                .WithOptional(p => p.OrderDets)
                .HasForeignKey(p => p.OrderId);
        }
    }

    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.Id);
            HasMany(p => p.OrderDetails)
                .WithOptional(p => p.Product)
                .HasForeignKey(p => p.ProductId);
        }

        public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
        {
            public EmployeeConfiguration()
            {
                HasKey(p => p.Id);
            }
        }
        public class EmployeeTerritoriesConfiguration : EntityTypeConfiguration<EmployeeTerritory>
        {
            public EmployeeTerritoriesConfiguration()
            {
                HasKey(p => p.Id)
                    .HasMany(p => p.Territories)
                    .WithOptional(p => p.EmplTerrits)
                    .HasForeignKey(p => p.TerritorryId);
                HasKey(p=>p.Id)
                    .HasMany(p=>p.Employees)
                    .WithOptional(p=>p)

                   
            }

        }

    }




}
