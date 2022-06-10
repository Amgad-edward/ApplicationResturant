using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("receiptitems")]
    public class ReceiptItems
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Receipt")]
        public int IdReceipt { get; set; }

        public Receipt? Receipt { get; set; }

        [ForeignKey("NameProduct")]
        public int IdNameproduct { get; set; }

        public NameProduct? NameProduct { get; set; }

        public double TotalWeights { get; set; }

        public decimal PriceAll { get; set; }

        public DateOnly? DateExpierd { get; set; }

        [NotMapped]
        public decimal Total => PriceAll > 0 ? (decimal)TotalWeights * PriceSamellWeight : 0;

        [NotMapped]
        public decimal PriceSamellWeight => PriceAll > 0 ? Math.Round(PriceAll / (decimal)TotalWeights,1) : 0;

    }
}
