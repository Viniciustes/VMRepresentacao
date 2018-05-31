﻿using Microsoft.EntityFrameworkCore;
using VMRepresentacao.Domain.Entities;
using VMRepresentacao.Infrastructure.Data.Mappings;

namespace VMRepresentacao.Infrastructure.Data.Contexts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerEntityConfiguration());
        }
    }
}
