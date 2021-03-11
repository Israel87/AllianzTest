using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllianzCarPolicy.UI.Web.Model.ViewModels
{
    public class CarBodyTypeVm
    {
        public int TypeId { get; set; }
        [Display(Name="Body Type")]
        public string BodyType { get; set; }
        [Display(Name = "Premium Value")]
        public decimal PremiumValue { get; set; }
    }
}
