using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("delivery")]
    public class Delivery
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Restaurant")]
        public int Idresetaurant { get; set; }
        public RestaurantAndBranches? Restaurant { get; set; }

        [ForeignKey("Customer")]
        public int? IdCustomer { get; set; }

        public Customer? Customer { get; set; }

        public DateOnly Date { get; set; }

        public int? IdToEmplyee { get; set; }

        public IEnumerable<DishRequired>? Dishes { get; set; }

        public decimal ServicesDelivery { get; set; }

        public decimal TotalPrice { get; set; }

        [ForeignKey("emplyeesDelviery")]
        public int IdEmpdelivery { get; set; }

        public Emplyees? EmplyeesDelviery { get; set; }

        public bool ISDone { get; set; }

    }
}
