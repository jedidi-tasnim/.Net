using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public string EstmateDuration { get; set; }
        public Plane ? plane { get; set; }
        [ForeignKey(nameof(Plane))]
        public int ? PlaneFK { get; set; }
        public List<Passenger> passengers { get; set; }
        public override string ToString()
        {
            return (Destination + "\n" +
                " " + Departure + " " + FlightDate + "" + FlightId + "" + EffectiveArrival + "" + EstmateDuration + "" );

        }
    }
}
