using AllianzCarPolicy.Core;
using AllianzCarPolicy.Core.Entities;
using AllianzCarPolicy.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllianzCarPolicy.Service.Concrete
{
    public class BodyTypeService : IBodyTypeService
    {
        private readonly IUnitOfWork _uow;

        public BodyTypeService(IUnitOfWork uow)
        {
            this._uow = uow;
        }

        public IEnumerable<CarBodyType> GetAll()
        {
            return _uow.BodyTypes.GetAll();
        }

        public CarBodyType GetById(long Id)
        {
            return _uow.BodyTypes.Get(Id);
        }

        public bool Save(CarBodyType obj, ref string message)
        {
            if (obj.TypeId == 0)
            {
                return Add(obj, ref message);
            }
            else
            {
                return Update(obj.TypeId, obj);
            }
        }

        private bool Add(CarBodyType obj, ref string message)
        {
            bool state = false;

            // Check if there is an existing name
            if (!_uow.BodyTypes.IsExists(obj))
            {
                _uow.BodyTypes.Add(obj);
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

        private bool Update(long Id, CarBodyType obj)
        {
            bool state = false;

            var objEx = _uow.BodyTypes.Get(Id);
            objEx = obj;
            objEx.TypeId = (int)Id;
            _uow.BodyTypes.Update(Id, objEx);
            int result = _uow.Complete();
            if (result > 0)
            {
                state = true;
            }
            return state;
        }


        public IEnumerable<CarBodyType> GetCarBodyTypeById(int Id)
        {
            return _uow.BodyTypes.GetAll().Where(m => m.TypeId == Id);
        }

        public bool Remove(CarBodyType obj)
        {
            throw new NotImplementedException();
        }

        public bool Remove(long id)
        {
            throw new NotImplementedException();
        }

      
    }
}
