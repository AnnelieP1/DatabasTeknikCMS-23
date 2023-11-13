using FM_EntetyFrameworkCore.Enteties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_EntetyFrameworkCore.Contexts
{
    internal class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<CustomerTypeEntity> CustomersType { get; set; }
    }
}
