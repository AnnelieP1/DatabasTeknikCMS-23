using Assignment.Contexts;
using Assignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repositories;

internal class AddressRepository : Repo<AddressEntity>
{
    private readonly DataContext _context;
    public AddressRepository(DataContext context) : base(context)
    {
        _context = context;
    }


}
