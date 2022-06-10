using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("categoryfood")]
    public class CategoryFood
    {
        [Key]
        public int Id { get; set; }

        [StringLength(70)]
        public string? Name { get; set; }

        [ForeignKey("Restaurant")]
        public int Idresetaurant { get; set; }
        public RestaurantAndBranches? Restaurant { get; set; }

    }
}
