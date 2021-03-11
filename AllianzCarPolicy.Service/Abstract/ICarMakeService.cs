using AllianzCarPolicy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllianzCarPolicy.Service.Abstract
{
    public interface ICarMakeService : IService<CarMake>
    {
        IEnumerable<CarMake> GetCarMakeById(int Id);
    }

}
