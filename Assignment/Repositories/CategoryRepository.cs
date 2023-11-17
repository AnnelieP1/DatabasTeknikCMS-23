using Assignment.Contexts;
using Assignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repositories;

internal class CategoryRepository : Repo<CategoryEntity>
{
    public CategoryRepository(DataContext dataContext) : base(dataContext)
    {
    }
}
