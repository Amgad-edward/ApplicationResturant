using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ModelData.Models
{
    [Table("dishfood")]
    public class DishFood
    {
        [Key]
        public int Id { get; set; }

        [StringLength(75)]
        public string? NameDish { get; set; }

        public decimal PriceBuy { get; set; }

        [ForeignKey("weightOfDish")]
        public int Idweight { get; set; }

        public WeightProduct? weightOfDish { get; set; }

        [StringLength(130)]
        public string? SubjectDetail { get; set; }

        [ForeignKey("category")]
        public int Idcategory { get; set; }

        public CategoryFood? category { get; set; }

        [ForeignKey("Restaurant")]
        public int Idresetaurant { get; set; }
        public RestaurantAndBranches? Restaurant { get; set; }

        public IEnumerable<DetailsDish>? DetailsDishes { get; set; }

        [NotMapped]
        public bool Available
        {
            get
            {
                if (DetailsDishes != null)
                {
                    foreach (var item in DetailsDishes)
                    {
                        if(item.CountWeight > item.Product?.TotalWeightIN)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                    return false;
            }
        }


    }
}
