using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllianzCarPolicy.UI.Web.Model.ViewModels
{
    public class CarModelVm
    {
        public int ModelId { get; set; }
        [Display(Name = "Model")]
        public string ModelName { get; set; }
    }
}
