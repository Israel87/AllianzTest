using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AllianzCarPolicy.Core.Entities
{
    [Table("Model")]
    public class CarModel
    {
        [Key]
        public int ModelId { get; set; }
        public string ModelName { get; set; }
    }
}
