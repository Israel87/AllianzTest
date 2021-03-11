﻿using AllianzCarPolicy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllianzCarPolicy.Service.Abstract
{
    public interface IBodyTypeService: IService<CarBodyType>
    {
        IEnumerable<CarBodyType> GetCarBodyTypeById(int Id);
    }
}
