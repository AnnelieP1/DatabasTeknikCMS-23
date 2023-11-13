using FM_EntetyFramework.Enteties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_EntetyFramework.Context;

internal class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
   public DbSet<ProductEntety> Products { get; set;}
   public DbSet<CategoryEntity> Categories { get; set;}

  
}
