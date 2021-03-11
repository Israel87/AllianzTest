using AllianzCarPolicy.Core;
using AllianzCarPolicy.Core.Repositories;
using AllianzCarPolicy.Data;
using AllianzCarPolicy.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllianzCarPolicy.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AllianzDBContext _context;
        public UnitOfWork(AllianzDBContext context)
        {
            _context = context;

            BodyTypes = new BodyTypeRepository(_context);
            CarMake = new CarMakeRepository(_context);
            CarModel = new CarModelRepository(_context);
            VehicleInfo = new VehicleInfoRepository(_context);
            Customer = new CustomerRepository(_context);

        }

        public IBodyTypeRepository BodyTypes { get; private set; }
        public ICarMakeRepository CarMake { get; private set; }

        public ICarModelRepository CarModel { get; private set; }

        public IVehicleInfoRepository VehicleInfo { get; private set; }

        public ICustomerRepository Customer { get; private set; }

        public int Complete()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
