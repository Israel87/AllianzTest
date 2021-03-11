using AllianzCarPolicy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllianzCarPolicy.Core.Repositories
{
    public interface IVehicleInfoRepository : IRepository<VehicleInfo>
    {
        bool IsExists(VehicleInfo obj);
    }
}
