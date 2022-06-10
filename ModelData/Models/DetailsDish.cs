using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("detailsdish")]
    public class DetailsDish
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Product")]
        public int IdProduct { get; set; }
        public Product? Product { get; set; }

        public double CountWeight { get; set; }

        public decimal PriceExpensive { get; set; }

        [ForeignKey("Dish")]
        public int IdDishFood { get; set; }

        public DishFood? Dish { get; set; }


    }
}
