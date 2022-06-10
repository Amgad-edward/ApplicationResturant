using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("accountreceipt")]
    public class AccountReceipt
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Receipt")]
        public int Idreceipt { get; set; }

        public Receipt? Receipt { get; set; }

        [ForeignKey("Restaurant")]
        public int Idrestaurant { get; set; }

        public RestaurantAndBranches? Restaurant { get; set; }

        public decimal MoneyPay { get; set; }

        public DateOnly DatePay { get; set; }

        public string? NumberPay { get; set; }

        public PaymentBy PaymentBy { get; set; }


    }
}
