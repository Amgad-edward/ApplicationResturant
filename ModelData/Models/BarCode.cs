using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("barcode")]
    public class BarCode
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        public string? Code { get; set; }

        [ForeignKey("NameProduct")]
        public int IdNameProduct { get; set; }

        public NameProduct? NameProduct { get; set; }
    }
}
