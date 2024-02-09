using FluentAPI3_22_10.Domain.Entities;
using FluentAPI3_22_10.Domain.Entities.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI3_22_10.DataAccess
{
    public class FluentContext:DbContext
    {
        public FluentContext()
            :base("StoreDB32210")
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new OrderMap());
        }
    }
}
