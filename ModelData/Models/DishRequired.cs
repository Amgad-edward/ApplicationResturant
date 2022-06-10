using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("dishrequired")]
    public class DishRequired
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Reservation")]
        public int IdReservation { get; set; }
        public Reservation? Reservation { get; set; }

        [ForeignKey("Dish")]
        public int IdDish { get; set; }

        public DishFood? Dish { get; set; }

        [ForeignKey("Delivery")]
        public int? IdDelivery{ get; set; }

        public Delivery? Delivery { get; set; }

        public bool ISDone { get; set; }

    }
}
