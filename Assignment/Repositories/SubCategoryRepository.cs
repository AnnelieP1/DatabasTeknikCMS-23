using Assignment.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repositories;

internal class SubCategoryRepository : Repo<SubCategoryRepository>
{
    public SubCategoryRepository(DataContext dataContext) : base(dataContext)
    {
    }
}
