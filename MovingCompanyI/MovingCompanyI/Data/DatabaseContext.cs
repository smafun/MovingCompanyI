using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovingCompanyI.Models;
using Microsoft.EntityFrameworkCore;

namespace MovingCompanyI.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<ServiceType>().ToTable("ServiceType");
        }
    }
}
