using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("NameProduct")]
        public int IdNameProduct { get; set; }

        public NameProduct? NameProduct { get; set; }

        public double TotalWeightIN { get; set; }

        public decimal Price { get; set; }

        public DateOnly? DateExpired { get; set; }

        [ForeignKey("Restaurant")]
        public int Idresetaurant { get; set; }
        public RestaurantAndBranches? Restaurant { get; set; }


    }
}
