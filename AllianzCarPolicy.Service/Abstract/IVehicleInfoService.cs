using AllianzCarPolicy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllianzCarPolicy.Service.Abstract
{
    public interface IVehicleInfoService : IService<VehicleInfo>
    {
        IEnumerable<VehicleInfo> GetVehicleInfoById(int Id);
    }
}
