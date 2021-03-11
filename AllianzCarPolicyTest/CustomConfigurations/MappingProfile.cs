using AllianzCarPolicy.Core.Entities;
using AllianzCarPolicy.UI.Web.Model.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllianzCarPolicy.UI.Web.CustomConfigurations
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {

            CreateMap<VehicleInfoVm, VehicleInfo>().ReverseMap();
            CreateMap<CarMakeVm, CarMake>().ReverseMap();
            CreateMap<CarBodyTypeVm, CarBodyType>().ReverseMap();
            CreateMap<CustomerVm, Customer>().ReverseMap();
            CreateMap<CarModelVm, CarModel>().ReverseMap();
   
        }
    }
}
