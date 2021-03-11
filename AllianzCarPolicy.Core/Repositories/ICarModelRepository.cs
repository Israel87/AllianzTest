using AllianzCarPolicy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllianzCarPolicy.Core.Repositories
{
    public interface ICarModelRepository: IRepository<CarModel>
    {
        bool IsExists(CarModel obj);
    }
}
