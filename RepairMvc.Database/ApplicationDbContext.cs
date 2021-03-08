using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RepairMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepairMvc.Database
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }


        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderProduct>()
                .HasKey(x => new { x.ProductId, x.OrderId });

            modelBuilder.Entity<Product>().Property(x => x.Price).HasPrecision(11, 2);


            modelBuilder.ApplyConfiguration<Order>(new OrderEntityTypeConfiguration());
        }

        public class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
        {
            public void Configure(EntityTypeBuilder<Order> orderConfiguration)
            {
                orderConfiguration.HasMany(o => o.Images)
                    .WithOne(i => i.Order)
                    .HasForeignKey(i => i.OrderId);
            }
        }
    }
}
