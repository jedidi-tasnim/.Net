using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Seat
    {
        public int SeatId { get; set; }
        [Required(ErrorMessage ="Error")]
        public string Name { get; set; }
        public string SeatNumber { get; set; }
        [Range(0,20)]
        public int size { get; set; }
      
        public virtual Plane plane { get; set; }
        public virtual Section? section { get; set; }
        public virtual List<Reservation> reservations { get; set; }
        [ForeignKey(nameof(Plane))]
        public int PlaneFk { get; set; }
        public int? SectionFk { get; set; }
    }
}
