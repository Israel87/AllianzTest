using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllianzCarPolicy.UI.Web.Model.ViewModels
{
    public class VehicleInfoVm
    {
        public int VehicleInfoId { get; set; }
        public string RegistrationNumber { get; set; }

        // Customer Details
        [Display(Name="Customer")]
        public int CustomerId { set; get; }


        // Car Make
        [Display(Name = "Make")]
        public int MakeId { get; set; }


        // BodyType to get Type and Premium value
        [Display(Name = "Body Type")]
        public int BodyTypeId { get; set; }


        // Car Model
        [Display(Name = "Model")]
        public int ModelId { get; set; }

    }
}
