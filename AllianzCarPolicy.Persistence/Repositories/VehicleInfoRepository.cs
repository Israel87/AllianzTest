using AllianzCarPolicy.Core.Entities;
using AllianzCarPolicy.Core.Repositories;
using AllianzCarPolicy.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllianzCarPolicy.Persistence.Repositories
{
    public class VehicleInfoRepository : Repository<VehicleInfo>, IVehicleInfoRepository
    {
        public VehicleInfoRepository(AllianzDBContext context)
          : base(context)
        { }

        public AllianzDBContext AllianzDBContext
        {
            get { return Context as AllianzDBContext; }
        }

        public bool IsExists(VehicleInfo obj)
        {
            VehicleInfo vehicleInfo = null;
            try
            {
                vehicleInfo = AllianzDBContext.VehicleInfos.First<VehicleInfo>(m => m.VehicleInfoId == obj.VehicleInfoId && m.CustomerId == obj.CustomerId);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return vehicleInfo != null ? true : false;
        }


        public override IEnumerable<VehicleInfo> GetAll()
        {
            return AllianzDBContext.VehicleInfos
                .Include(m => m.CarModel)
                .Include(m => m.CarBodyType)
                .Include(m => m.CarMake)
                .Include(m => m.Customer);
        }
    }
}
