using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Services.MenuService;

internal class MenuService
{
    private readonly DbContext _context;

    public MenuService(DbContext context)
    {
        _context = context;
    }

}
