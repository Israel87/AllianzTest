using AllianzCarPolicy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllianzCarPolicy.Service.Abstract
{
    public interface ICustomerService : IService<Customer>
    {
        IEnumerable<Customer> GetCustomerById(int Id);
    }
}
