
using CustomerCloud.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCloud.Repository
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("CustomerCloud") { }

        DbSet<CustomerEntity> Customers { get; set; }
        DbSet<AddressEntity> Addresses { get; set; }
        DbSet<OrderDetailEntity> OrderDetails { get; set; }
        DbSet<OrderEntity> Orders { get; set; } 
        DbSet<ProductEntity> Products { get; set; }
    }
}
