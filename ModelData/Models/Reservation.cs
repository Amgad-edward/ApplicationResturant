using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("reservation")]
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Restaurant")]
        public int Idresetaurant { get; set; }
        public RestaurantAndBranches? Restaurant { get; set; }

        public DateOnly Date { get; set; }

        public TimeOnly? Timestart { get; set; }

        public TimeOnly? TimeEnd { get; set; }

        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }

        public Customer? Customer { get; set; }
        public bool IsPayment { get; set; }
        public IEnumerable<TablesReservation>? TablesReserved { get; set; }

        public IEnumerable<DishRequired>? DishFoods { get; set; }

        public IEnumerable<ServiceReservation>? ServiceReservations { get; set; }

        [NotMapped]
        public decimal Totals
        {
            get
            {
                var total = DishFoods is not null ? DishFoods.Sum(x => x.Dish.PriceBuy) : 0;
                return total;
            }
            
        }

        [NotMapped]
        public decimal TotalServices { get; set; }

        [NotMapped]
        public decimal TotalAll => Totals + TotalServices;



    }
}
