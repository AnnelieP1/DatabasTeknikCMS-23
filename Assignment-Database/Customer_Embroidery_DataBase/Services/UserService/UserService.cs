using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Services.UserService
{
    internal class UserService
    {
        private readonly DbContext _context;

        public UserService(DbContext context)
        {
            _context = context;
        }
    }


}
