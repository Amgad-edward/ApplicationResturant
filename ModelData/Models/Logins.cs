using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("logins")]
    public class Logins
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30) , Required]
        public string? Username { get; set; }

        [StringLength(30), Required]
        public string? Password { get; set; }

        public bool ISAdmin { get; set; }

        public bool Kitchen { get; set; }

        public bool Cacher { get; set; }

        public bool Garson { get; set; }

        public bool DataEntry { get; set; }

        public bool TelSales { get; set; }

        [ForeignKey("emp")]
        public int IdEmplyee { get; set; }

        public Emplyees? emp { get; set; }
    }
}
