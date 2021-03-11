using AllianzCarPolicy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllianzCarPolicy.Service.Abstract
{
    public interface ICarModelService : IService<CarModel>
    {
        IEnumerable<CarModel> GetCarModelById(int Id);
    }

}
