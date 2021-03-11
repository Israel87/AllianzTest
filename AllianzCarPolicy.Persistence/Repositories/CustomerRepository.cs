using AllianzCarPolicy.Core.Entities;
using AllianzCarPolicy.Core.Repositories;
using AllianzCarPolicy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllianzCarPolicy.Persistence.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AllianzDBContext context) : base(context)
        { }

        public AllianzDBContext AllianzDBContext
        {
            get { return Context as AllianzDBContext; }
        }
        public bool IsExists(Customer obj)
        {
            Customer customer = null;
            try
            {
                customer = AllianzDBContext.Customers.First<Customer>(m => m.CustomerId == obj.CustomerId);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return customer != null ? true : false;
        }

        public override IEnumerable<Customer> GetAll()
        {
            return AllianzDBContext.Customers;
        }
    }
}