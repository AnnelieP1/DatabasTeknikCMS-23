using _01_G_EntetyFrameWorkCore.Enteties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_G_EntetyFrameWorkCore.Contexts;

internal class DataContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DataBasTeknik\Lektion-4\01_G_EntetyFrameWorkCore\Contexts\g_database.mdf;Integrated Security=True;Connect Timeout=30");

    }
    public DbSet<UserEntety> Users { get; set; }
    public DbSet<AddressEntety> Address { get; set; }
    public DbSet<RoleEntety> Role { get; set; }

}
