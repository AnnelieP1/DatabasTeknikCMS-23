using Assignment.Contexts;
using Assignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repositories
{
    internal class CustomerRepository : Repo<CustomerEntity>
    {
        public CustomerRepository(DataContext dataContext) : base(dataContext)
        {

        }

        internal Task<CustomerEntity> CreateAsync(CustomerEntity customerEntity)
        {
            throw new NotImplementedException();
        }

        internal Task<bool> ExistsAsync(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        internal Task<IEnumerable<object>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        internal Task GettAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
