using AllianzCarPolicy.Core.Entities;
using AllianzCarPolicy.Core.Repositories;
using AllianzCarPolicy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllianzCarPolicy.Persistence.Repositories
{
    public class CarMakeRepository : Repository<CarMake>, ICarMakeRepository
    {
        public CarMakeRepository(AllianzDBContext context) : base(context)
        { }

        public AllianzDBContext AllianzDBContext
        {
            get { return Context as AllianzDBContext; }
        }
        public bool IsExists(CarMake obj)
        {
            CarMake carMake = null;
            try
            {
                carMake = AllianzDBContext.Makes.First<CarMake>(m => m.MakeId == obj.MakeId);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return carMake != null ? true : false;
        }

        public override IEnumerable<CarMake> GetAll()
        {
            return AllianzDBContext.Makes;
        }
    }
}
