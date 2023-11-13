using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Contexts;

internal class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

}
