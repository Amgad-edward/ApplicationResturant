using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("table")]
    public class TheTable
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string? TableCode { get; set; }

        public int CountChair { get; set; }

        [ForeignKey("Area")]
        public int IdArea { get; set; }

        public Area? Area { get; set; }

        [ForeignKey("Restaurant")]
        public int Idresetaurant { get; set; }
        public RestaurantAndBranches? Restaurant { get; set; }
        public bool IsRreserved { get; set; }
    }
}
