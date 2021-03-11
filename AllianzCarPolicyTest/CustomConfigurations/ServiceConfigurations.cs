using AllianzCarPolicy.Service.Abstract;
using AllianzCarPolicy.Service.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllianzCarPolicy.UI.Web.CustomConfigurations
{
    public class ServiceConfigurations
    {
        public static void Configure(IServiceCollection services)
        { 
            services.AddTransient<IBodyTypeService, BodyTypeService>();
            services.AddTransient<ICarMakeService, CarMakeService>();
            services.AddTransient<ICarModelService, CarModelService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IVehicleInfoService, VehicleInfoService>();

        }
    }
}
