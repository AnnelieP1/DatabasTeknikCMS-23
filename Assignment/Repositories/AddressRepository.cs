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
    public AddressRepository(DataContext dataContext) : base(dataContext)
    {

    }

    internal Task<AddressEntity> CreateAsync()
    {
        throw new NotImplementedException();
    }

    internal Task<AddressEntity> GetAsync(Func<object, bool> value)
    {
        throw new NotImplementedException();
    }
}
