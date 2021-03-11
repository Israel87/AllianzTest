using AllianzCarPolicy.Core.Entities;
using AllianzCarPolicy.Core.Repositories;
using AllianzCarPolicy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllianzCarPolicy.Persistence.Repositories
{
    public class CarModelRepository: Repository<CarModel>, ICarModelRepository
    {
        public CarModelRepository(AllianzDBContext context)
         : base(context)
        { }

        public AllianzDBContext AllianzDBContext
        {
            get { return Context as AllianzDBContext; }
        }

        public bool IsExists(CarModel obj)
        {
            CarModel carModel = null;
            try
            {
                carModel = AllianzDBContext.Models.First<CarModel>(m => m.ModelId == obj.ModelId);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return carModel != null ? true : false;
        }

        public override IEnumerable<CarModel> GetAll()
        {
            return AllianzDBContext.Models;
        }
    }
}
