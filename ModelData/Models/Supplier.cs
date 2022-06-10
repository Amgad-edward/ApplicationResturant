using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("supplier")]
    public class Supplier
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        public string? NameSupplier { get; set; }

        [StringLength(77)]
        public string? Phones { get; set; }

        public IEnumerable<Receipt>? Receipts { get; set; }
    }
}
