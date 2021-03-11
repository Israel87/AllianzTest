using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AllianzCarPolicy.Core.Entities
{
    [Table("BodyType")]
    public class CarBodyType
    {
        [Key]
        public int TypeId { get; set; }
        public string BodyType { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public Decimal PremiumValue { get; set; }
    }
}
