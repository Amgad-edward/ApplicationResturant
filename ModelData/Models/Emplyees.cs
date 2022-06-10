using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ModelData.Models
{
    [Table("emplyees")]
    public class Emplyees
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30),Required]
        public string? Name { get; set; }

        [StringLength(75),Required]
        public string? Jop { get; set; }

        public decimal SalaryHour { get; set; }

        [JsonConverter(typeof(DateConvertJosndateoly))]
        public DateOnly? DateBirth { get; set; }

        [JsonConverter(typeof(DateConvertJosndateoly))]
        public DateOnly? DatestartWork { get; set; }

        [ForeignKey("Restaurant")]
        public int Idresetaurant { get; set; }
        public RestaurantAndBranches? Restaurant { get; set; }

        public IEnumerable<Delivery>? DeliverysOFThisEmplyess { get; set; }

        public IEnumerable<WorkTable>? WorksTable { get; set; }

        public DayWeek Weekend { get; set; }
    }
}
