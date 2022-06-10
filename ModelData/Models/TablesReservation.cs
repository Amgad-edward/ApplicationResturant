using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("tablesreservation")]
    public class TablesReservation
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Revervation")]
        public int IdRevervation { get; set; }

        public Reservation? Revervation { get; set; }

        [ForeignKey("Table")]
        public int IdTable { get; set; }

        public TheTable? Table { get; set; }
    }
}
