using LibraryManagementSystemApp.Data.Interfaces;
using LibraryManagementSystemApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystemApp.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}
