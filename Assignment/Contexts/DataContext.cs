using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Contexts;

internal class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<AddressEntity> Addresses { get; set; }
    public DbSet<CustomerEntity> Customers { get; set; }
    public DbSet<InvoiceEntity> Invoices { get; set; }
    public DbSet<InvoiceLineEntity> InvoicesLines { get; set; }
    public DbSet<OrderEntity> Orders { get; set; }
    public DbSet<OrderRowEntity> OrdersRows { get; set;}
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<QuantityUnitEntity> QuanittyUnits { get; set;}
    public DbSet<CategoryEntity> CategoryEntities { get; set; }
    public DbSet<SubCategoryEntity> SubCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InvoiceLineEntity>().HasKey(x => new { x.InvoiceId, x.ProductId });
        modelBuilder.Entity<OrderRowEntity>().HasKey(x => new { x.OrderId, x.ProductId });
    }
}
