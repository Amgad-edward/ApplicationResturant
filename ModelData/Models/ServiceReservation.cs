using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelData.Models
{
    [Table("servicereservation")]
    public class ServiceReservation
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Reservation")]
        public int IdReservation { get; set; }

        public Reservation? Reservation { get; set; }

        [ForeignKey("Service")]
        public int IdService { get; set; }

        public Service? Service { get; set; }
    }
}
