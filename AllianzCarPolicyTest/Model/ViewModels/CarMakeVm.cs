using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllianzCarPolicy.UI.Web.Model.ViewModels
{
    public class CarMakeVm
    {
        public int MakeId { get; set; }
        [Display(Name = "Make")]
        public string MakeName { get; set; }
    }
}
