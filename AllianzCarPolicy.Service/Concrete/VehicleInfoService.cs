using AllianzCarPolicy.Core;
using AllianzCarPolicy.Core.Entities;
using AllianzCarPolicy.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllianzCarPolicy.Service.Concrete
{
    public class VehicleInfoService : IVehicleInfoService
    {
        private readonly IUnitOfWork _uow;

        public VehicleInfoService(IUnitOfWork uow)
        {
            this._uow = uow;
        }
        public IEnumerable<VehicleInfo> GetAll()
        {
            return _uow.VehicleInfo.GetAll();
        }

        public VehicleInfo GetById(long Id)
        {
            return _uow.VehicleInfo.Get(Id);
        }

        public bool Save(VehicleInfo obj, ref string message)
        {
            if (obj.VehicleInfoId == 0)
            {
                return Add(obj, ref message);
            }
            else
            {
                return Update(obj.VehicleInfoId, obj);
            }
        }

        private bool Add(VehicleInfo obj, ref string message)
        {
            bool state = false;

            // Check if there is an existing name
            if (!_uow.VehicleInfo.IsExists(obj))
            {
                _uow.VehicleInfo.Add(obj);
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

        private bool Update(long Id, VehicleInfo obj)
        {
            bool state = false;

            var objEx = _uow.VehicleInfo.Get(Id);
            objEx = obj;
            objEx.VehicleInfoId = (int)Id;
            _uow.VehicleInfo.Update(Id, objEx);
            int result = _uow.Complete();
            if (result > 0)
            {
                state = true;
            }
            return state;
        }
        public IEnumerable<VehicleInfo> GetVehicleInfoById(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(VehicleInfo obj)
        {
            throw new NotImplementedException();
        }

        public bool Remove(long id)
        {
            throw new NotImplementedException();
        }

  
    }
}
