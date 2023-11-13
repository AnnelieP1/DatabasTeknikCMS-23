using Assignment.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repositories;

internal abstract class Repo<Tentity> where Tentity : class
{
    private readonly DataContext _dataContext;
    protected Repo(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

}
