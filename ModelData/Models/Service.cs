using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelData.Models
{
    [Table("service")]
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [StringLength(70) , Required]
        public string? ServiceName { get; set; }

        [Required]
        public PaymentService PaymentService { get; set; }

        public decimal MoneyConst { get; set; }

        public int Rate { get; set; }

        [ForeignKey("Restourant")]
        public int IdRestourant { get; set; }

        public RestaurantAndBranches? Restourant { get; set; }

        public bool IsFixed { get; set; }

    }
}
