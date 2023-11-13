using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Services.AdminService
{
    internal class AdminService
    {
        private readonly DbContext _context; 

        public AdminService(DbContext context)
        {
            _context = context;
        }   
    }
}
