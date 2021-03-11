using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AllianzCarPolicy.Core.Entities
{
    [Table("VehicleInfo")]
    public class VehicleInfo
    {
        [Key]
        public int VehicleInfoId { get; set; }
        public string RegistrationNumber { get; set; }

        // Customer Details
        public int CustomerId { set; get; }
        public Customer Customer { set; get; }

        // Car Make
        public int MakeId { get; set; }
        public CarMake CarMake { get; set; }

        // BodyType to get Type and Premium value
        public int BodyTypeId { get; set; }
        public CarBodyType CarBodyType { get; set; }

        // Car Model
        public int ModelId { get; set; }
        public CarModel CarModel { get; set; }







    }
}
