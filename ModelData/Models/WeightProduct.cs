using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("weightproduct")]
    public class WeightProduct
    {
        [Key]
        public int ID { get; set; }

        [StringLength(30)]
        public string? NameBig { get; set; }

        [StringLength(30)]
        public string? NameSmall { get; set; }

        public double CountSamll { get; set; }
    }
}
