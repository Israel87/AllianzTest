using AllianzCarPolicy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllianzCarPolicy.Core.Repositories
{
    public interface IBodyTypeRepository: IRepository<CarBodyType> 
    {
        bool IsExists(CarBodyType obj);
    }
   
}
