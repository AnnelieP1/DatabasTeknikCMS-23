using Aspose.Pdf;
using Assignment.Contexts;
using Assignment.Entities;
using Assignment.Models;
using Assignment.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repositories
{
    internal class CustomerRepository : Repo<CustomerEntity>
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext context) : base(context)
        {
            _context = context; 
        }

        public override async Task<IEnumerable<CustomerEntity>> GetAllAsync()
        {
            return await _context.Customers.Include(x => x.Address).ToListAsync();
            
        }
       
    }
}
