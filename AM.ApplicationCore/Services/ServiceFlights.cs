using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlights : IServiceFlight
    {
        public void DestinationGroupedFlights()
        {
            throw new NotImplementedException();
        }

        public double DurationAverage(string destination)
        {
            throw new NotImplementedException();
        }

        public List<DateTime> GetFlightDates(string destination)
        {
            
            throw new NotImplementedException();
        }

        public void GetFlights(string filterType, string filterValue)
        {
            throw new NotImplementedException();
        }

        public List<Flight> OrderedDurationFlights()
        {
            throw new NotImplementedException();
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            throw new NotImplementedException();
        }

        public List<Traveller> SeniorTravellers(Flight flight)
        {
            throw new NotImplementedException();
        }

        public void ShowFlightDetails(System.Numerics.Plane plane)
        {
            throw new NotImplementedException();
        }
    }
}
