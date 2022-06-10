using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("receipt")]
    public class Receipt
    {
        [Key]
        public int Id { get; set; }

        [StringLength(27)]
        public string? CodeNumber { get; set; }

        public DateOnly Date { get; set; }

        [ForeignKey("Restourant")]
        public int Idrestourant { get; set; }
        public RestaurantAndBranches? Restourant { get; set; }

        [ForeignKey("Supplier")]
        public int Idsupplier { get; set; }

        public Supplier? Supplier { get; set; }

        public int Discount { get; set; }

        [NotMapped]
        public decimal TotalMoney
        {
            get
            {
                var total = ReceiptItems is not null ? ReceiptItems.Sum(x => x.Total) : 0;
                if (Discount > 0 && total > 0)
                    total = total - Math.Round(total * Discount / 100,1);

                return total;
            }
        }

        [NotMapped]
        public decimal Remmaining
        {
            get
            {
                var Remm = ReceiptItems is not null ? TotalMoney : 0;
                if (AccountReceipts is not null)
                    Remm -= AccountReceipts.Sum(x => x.MoneyPay);
                return Remm;
            }
        }

        public IEnumerable<ReceiptItems>? ReceiptItems { get; set; }

        public IEnumerable<AccountReceipt>? AccountReceipts { get; set; }
    }
}
