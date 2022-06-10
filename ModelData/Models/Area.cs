using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("area")]
    public class Area
    {
        [Key]
        public int id { get; set; }

        [StringLength(30)]
        public string? NameArea { get; set; }

        [ForeignKey("Restaurant")]
        public int Idresetaurant { get; set; }

        public RestaurantAndBranches? Restaurant { get; set; }
        public IEnumerable<TheTable>? Tables { get; set; }
    }
}
