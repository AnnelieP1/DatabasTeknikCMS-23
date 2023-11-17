using Assignment.Contexts;
using Assignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repositories;

internal class QuantityUnitRepository : Repo<QuantityUnitEntity>
{
    public QuantityUnitRepository(DataContext dataContext) : base(dataContext)
    {
    }
}
