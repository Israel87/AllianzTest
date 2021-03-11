using AllianzCarPolicy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllianzCarPolicy.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IBodyTypeRepository BodyTypes { get;  }
        ICarMakeRepository CarMake { get; }
        ICarModelRepository CarModel { get; }
        IVehicleInfoRepository VehicleInfo { get;  }
        ICustomerRepository Customer { get; }

        int Complete();
    }
}
