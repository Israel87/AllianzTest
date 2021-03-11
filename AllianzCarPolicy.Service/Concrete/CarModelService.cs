using AllianzCarPolicy.Core;
using AllianzCarPolicy.Core.Entities;
using AllianzCarPolicy.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllianzCarPolicy.Service.Concrete
{
    public class CarModelService : ICarModelService
    {
        private readonly IUnitOfWork _uow;

        public CarModelService(IUnitOfWork uow)
        {
            this._uow = uow;
        }
        public IEnumerable<CarModel> GetAll()
        {
            return _uow.CarModel.GetAll();
        }

        public CarModel GetById(long Id)
        {
            return _uow.CarModel.Get(Id);
        }

        public bool Save(CarModel obj, ref string message)
        {
            if (obj.ModelId == 0)
            {
                return Add(obj, ref message);
            }
            else
            {
                return Update(obj.ModelId, obj);
            }
        }

        private bool Add(CarModel obj, ref string message)
        {
            bool state = false;

            // Check if there is an existing name
            if (!_uow.CarModel.IsExists(obj))
            {
                _uow.CarModel.Add(obj);
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

        private bool Update(long Id, CarModel obj)
        {
            bool state = false;

            var objEx = _uow.CarModel.Get(Id);
            objEx = obj;
            objEx.ModelId = (int)Id;
            _uow.CarModel.Update(Id, objEx);
            int result = _uow.Complete();
            if (result > 0)
            {
                state = true;
            }
            return state;
        }
        public IEnumerable<CarModel> GetCarModelById(int Id)
        {
            return _uow.CarModel.GetAll().Where(m => m.ModelId == Id);
        }

        public bool Remove(CarModel obj)
        {
            throw new NotImplementedException();
        }

        public bool Remove(long id)
        {
            throw new NotImplementedException();
        }

    }
}
