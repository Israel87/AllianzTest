using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AllianzCarPolicy.Core.Entities
{
    [Table("Make")]
    public class CarMake
    {
        [Key]
        public int MakeId { get; set; }
        public string MakeName { get; set; }
    }
}
