using Customer_Embroidery_DataBase.Enteties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Context;

internal class DataBase : DbContext
{
    public DataBase(DbContextOptions<DataBase> options) : base(options)
    {
    }
    
    public DbSet<UserEntity> Users { get; set; } = null!;
    public DbSet<AddressEntity> Addresses { get; set; } = null!;
    public DbSet<OrderEntity> Orders { get; set; } = null!;
    public DbSet<ProductEntity> Products { get; set; } = null!;
    public DbSet<OrderproductEntity> OrderProducts { get; set; } = null!;
    public DbSet<CategoryEntity> Categories { get; set; } = null!;
    public DbSet<InvoiceEntity> Invoices { get; set; } = null!;
    public DbSet<InvoiceLineEntity> InvoiceLines { get; set; } = null!;
    public DbSet<SubCategoryEntity> SubCategories { get; set; } = null!;
    public DbSet<AdminEntity> Admins { get; set; } = null!;

}
