using FM_EntetyFrameworkCore.Contexts;
using FM_EntetyFrameworkCore.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_EntetyFrameworkCore.Repositories;



internal class CustomerRepository : Repo<CustomerEntity>
{
    private readonly DataContext _context;

    public CustomerRepository(DataContext context) : base(context)
    {
        _context = context;
    }
}
