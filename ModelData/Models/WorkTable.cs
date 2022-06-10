using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("worktable")]
    public class WorkTable
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Emplyee")]
        public int IdEmplyee { get; set; }
        public Emplyees? Emplyee { get; set; }

        [Column(TypeName = "date")]
        public DateOnly Date { get; set; }

        [Column(TypeName = "Time")]
        public TimeOnly TimePresence { get; set; }

        [Column(TypeName = "Time")]
        public TimeOnly TimeLeave { get; set; }
    }
}
