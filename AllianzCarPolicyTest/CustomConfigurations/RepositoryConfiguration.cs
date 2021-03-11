using AllianzCarPolicy.Core;
using AllianzCarPolicy.Core.Repositories;
using AllianzCarPolicy.Persistence;
using AllianzCarPolicy.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllianzCarPolicy.UI.Web.CustomConfigurations
{
    public class RepositoryConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IBodyTypeRepository,BodyTypeRepository >();
            services.AddTransient<ICarMakeRepository, CarMakeRepository>();
            services.AddTransient<ICarModelRepository, CarModelRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IVehicleInfoRepository, VehicleInfoRepository>();

        }
    }
}
