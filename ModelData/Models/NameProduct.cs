using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("nameproduct")]
    public class NameProduct
    {
        [Key]
        public int ID { get; set; }

        [StringLength(30)]
        public string? Name { get; set; }

        [ForeignKey("weight")]
        public int WeightId { get; set; }

        public WeightProduct? weight { get; set; }

        public IEnumerable<BarCode>? BarCodess { get; set; }

    }
}
