using AllianzCarPolicy.Core;
using AllianzCarPolicy.Core.Entities;
using AllianzCarPolicy.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllianzCarPolicy.Service.Concrete
{
    public class CarMakeService : ICarMakeService
    {
        private readonly IUnitOfWork _uow;

        public CarMakeService(IUnitOfWork uow)
        {
            this._uow = uow;
        }
        public IEnumerable<CarMake> GetAll()
        {
            return _uow.CarMake.GetAll();
        }

        public CarMake GetById(long Id)
        {
            return _uow.CarMake.Get(Id);
        }

        public bool Save(CarMake obj, ref string message)
        {

            if (obj.MakeId == 0)
            {
                return Add(obj, ref message);
            }
            else
            {
                return Update(obj.MakeId, obj);
            }
        }


        private bool Add(CarMake obj, ref string message)
        {
            bool state = false;

            // Check if there is an existing name
            if (!_uow.CarMake.IsExists(obj))
            {
                _uow.CarMake.Add(obj);
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

        private bool Update(long Id, CarMake obj)
        {
            bool state = false;

            var objEx = _uow.CarMake.Get(Id);
            objEx = obj;
            objEx.MakeId = (int)Id;
            _uow.CarMake.Update(Id, objEx);
            int result = _uow.Complete();
            if (result > 0)
            {
                state = true;
            }
            return state;
        }

        public IEnumerable<CarMake> GetCarMakeById(int Id)
        {
            return _uow.CarMake.GetAll().Where(m => m.MakeId == Id);
        }

        public bool Remove(CarMake obj)
        {
            throw new NotImplementedException();
        }

        public bool Remove(long id)
        {
            throw new NotImplementedException();
        }

        
    }
}
