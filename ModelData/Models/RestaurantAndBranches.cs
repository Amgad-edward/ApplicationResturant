using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("restaurantandbranches")]
    public class RestaurantAndBranches
    {
        [Key]
        public int Id { get; set; }

        [StringLength(70) ,Required]
        public string? NameAndBranch { get; set; }

        [StringLength(130),Required]
        public string? Address { get; set; }

        [StringLength(101)]
        public string? LocationCode { get; set; }

        [StringLength(101)]
        public string? Phones { get; set; }

        [StringLength(10000000)]
        public byte[]? Photo { get; set; }

        public IEnumerable<Product>? Products { get; set; }

        public IEnumerable<TheTable>? Tables { get; set; }

        public IEnumerable<Reservation>? Reservations { get; set; }

        public IEnumerable<DishFood>? DishFoods { get; set; }

        public IEnumerable<Area>? Areas { get; set; }

        public IEnumerable<Emplyees>? Emplyees { get; set; }

        public IEnumerable<Receipt>? Receipts { get; set; }

        public IEnumerable<AccountReceipt>? AccountReceipts { get; set; }

        public IEnumerable<Service>? Services { get; set; }


    }
}
