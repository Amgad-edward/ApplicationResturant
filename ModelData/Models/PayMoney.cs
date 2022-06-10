using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("paymoney")]
    public class PayMoney
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Reservation")]
        public int IdReservation { get; set; }

        public Reservation? Reservation { get; set; }

        public decimal PriceFood { get; set; }

        public decimal PriceServecis { get; set; }

        [NotMapped]
        public decimal TotalPrice
        {
            get
            {
                return PriceFood + PriceServecis;
            }
        }

        [StringLength(47)]
        public string? CodeReceipt { get; set; }

        [Required]
        public PaymentBy paymentBy { get; set; }

        [StringLength(77)]
        public string? VisaCode { get; set; }

        [ForeignKey("Restaurant")]
        public int Idresetaurant { get; set; }
        public RestaurantAndBranches? Restaurant { get; set; }


       

    }
}
