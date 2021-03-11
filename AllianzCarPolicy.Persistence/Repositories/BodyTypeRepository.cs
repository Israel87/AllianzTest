using AllianzCarPolicy.Core.Entities;
using AllianzCarPolicy.Core.Repositories;
using AllianzCarPolicy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllianzCarPolicy.Persistence.Repositories
{
    public class BodyTypeRepository : Repository<CarBodyType>, IBodyTypeRepository
    {

        public BodyTypeRepository(AllianzDBContext context)
      : base(context)
        { }

        public AllianzDBContext AllianzDBContext
        {
            get { return Context as AllianzDBContext; }
        }
        public bool IsExists(CarBodyType obj)
        {

            CarBodyType carBodyType = null;
            try
            {
                carBodyType = AllianzDBContext.BodyTypes.First<CarBodyType>(m => m.TypeId == obj.TypeId);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return carBodyType != null ? true : false;
        }

        public override IEnumerable<CarBodyType> GetAll()
        {
            return AllianzDBContext.BodyTypes;
        }
    }
}
