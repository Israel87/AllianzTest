using AllianzCarPolicy.Core;
using AllianzCarPolicy.Core.Entities;
using AllianzCarPolicy.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllianzCarPolicy.Service.Concrete
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _uow;

        public CustomerService(IUnitOfWork uow)
        {
            this._uow = uow;
        }
        public IEnumerable<Customer> GetAll()
        {
            return _uow.Customer.GetAll();
        }

        public Customer GetById(long Id)
        {
            return _uow.Customer.Get(Id);
        }

        public bool Save(Customer obj, ref string message)
        {
            if (obj.CustomerId == 0)
            {
                return Add(obj, ref message);
            }
            else
            {
                return Update(obj.CustomerId, obj);
            }
        }

        private bool Add(Customer obj, ref string message)
        {
            bool state = false;

            // Check if there is an existing name
            if (!_uow.Customer.IsExists(obj))
            {
                _uow.Customer.Add(obj);
                int result = _uow.Complete();
                if (result > 0)
                {
                    state = true;
                }
            }
            else
            {
                message = "Data Exists!";
            }

            return state;
        }

        private bool Update(long Id, Customer obj)
        {
            bool state = false;

            var objEx = _uow.Customer.Get(Id);
            objEx = obj;
            objEx.CustomerId = (int)Id;
            _uow.Customer.Update(Id, objEx);
            int result = _uow.Complete();
            if (result > 0)
            {
                state = true;
            }
            return state;
        }



        public IEnumerable<Customer> GetCustomerById(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Customer obj)
        {
            bool state = false;

            _uow.Customer.Remove(obj);
            int result = _uow.Complete();
            if (result > 0)
            {
                state = true;
            }
            return state;
        }

        public bool Remove(long id)
        {
            throw new NotImplementedException();
        }

      


    }
}
