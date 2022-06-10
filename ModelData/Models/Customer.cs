using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("customer")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        public string? Name { get; set; }

        [StringLength(50)]
        public string? Phone { get; set; }

        [StringLength(130)]
        public string? Address { get; set; }

        public string? Password { get; set; }

        public IEnumerable<Reservation>? Reservations { get; set; }
        public IEnumerable<Delivery>? Deliveries { get; set; }
    }
}
