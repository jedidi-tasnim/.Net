using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Plane = AM.ApplicationCore.Domain.Plane;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {

        
        public List<Flight> Flights { get; set; } = new List<Flight>();

        // 6
        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> z = new List<DateTime>();
            //for(int i = 0; i < Flights.Count; i++)
            //{
            //    if (Flights[i].Destination==destination)
            //        dates.Add(Flights[i].FlightDate);
            //}
            //return dates;

            // 7
            //List<DateTime> dates = new List<DateTime>();
            //foreach (var flight in Flights)
            //{
            //    if (flight.Destination == destination)
            //    {
            //        dates.Add(flight.FlightDate);
            //    }

            //}

            

            var query = Flights
                .Where(Flights => Flights.Destination == destination)
                .Select(Flights => Flights.FlightDate).ToList();

            return query;
        }

        // 8
        public List<Flight> GetFlights(string filterValue, Func<Flight, String, Boolean> condition)
        {
            List<Flight> flights = new List<Flight>();

            foreach (var flight in Flights)
            {
                if (condition(flight, filterValue))
                {
                    flights.Add(flight);
                    Console.WriteLine(flight);
                }
            }

         
            return flights;
        }

        // 9 
        void ShowFlightDetails(Plane plane)
        {
            var query = Flights
                .Where(f => f.plane.Planeid == plane.Planeid)
                .Select(f => new { f.Destination, f.FlightDate });
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
        // 11

        int ProgrammedFlightNumber(DateTime startDate)
        {
            var query = Flights
                .Count(f => f.FlightDate > startDate && (f.FlightDate - startDate).TotalDays < 7);
            return query;
        }

        // 12
        Double DurationAverage(string destination)
        {
            var query = Flights
                .Where(f => f.Destination.Equals(destination))
                .Average(f => f.EstmateDuration);
            return query;
        }

        // 13
        List<Flight> OrderedDurationFlights()
        {
            
            var query = from f in Flights
                        orderby f.EstmateDuration descending
                        select (f);

            return query.ToList();
        }

        // 14
        List<Traveller> SeniorTravellers(Flight flight)
        {
            var query = flight.passengers.OfType<Traveller>()
                    
                    .OrderBy(p => p.BirthDate).Take(3).ToList();

            List<Passenger> p = new List<Passenger>(query);  
            return query;
        }

        // 15
        void DestinationGroupedFlights()
        {
            var query = Flights
                .GroupBy(f => f.Destination).ToList();
            foreach (var f in query)
            {
                Console.WriteLine("Destination : " + f.Key);
                foreach (var g in f)
                {
                    Console.WriteLine(g.FlightDate);
                }
            }
        }


        delegate void FlightDetailsDel(Plane plane);

        
        FlightDetailsDel printDetails = (plane) =>
        {
            Console.WriteLine("Plane details:");
            Console.WriteLine("ID: {0}", plane.Planeid);
            Console.WriteLine("Capacity: {0}", plane.Capacity);
            Console.WriteLine("Manufacture Date: {0}", plane.ManufactureDate);
            Console.WriteLine("Plane Type: {0}", plane.PlaneType);
        };



        delegate float DurationAverageDel(string destination);

        DurationAverageDel getAverageDuration = (destination) =>
        {
            float totalDuration = 0;
            int count = 0;
            List<Flight> flights = new List<Flight>();

            foreach (Flight flight in flights)
            {
                if (flight.Destination == destination)
                {
                    totalDuration += flight.EstmateDuration;
                    count++;
                }
            }

            if (count > 0)
            {
                return totalDuration / count;
            }
            else
            {
                return 0;
            }
        };

        //17 :

        private FlightDetailsDel showFlightDetails;
        private DurationAverageDel durationAverage;

        public void GetFlightDetails(Plane plane)
        {
 
            showFlightDetails(plane);
        }

        public void GetDurationAverage(string destination)
        {
            
            double averageDuration = durationAverage(destination);
            Console.WriteLine($"Average duration to {destination}: {averageDuration}");
        }


        //18 - 

        //    public ServiceFlight()
        //    {
        //        showFlightDetails = plane => {
        //            var query = Flights
        //                .Where(f => f.plane.PlaneId == plane.PlaneId)
        //                .Select(f => new { f.Destination, f.FlightDate });

        //            foreach (var item in query)
        //            {
        //                Console.WriteLine(item);
        //            }
        //        };


        //        durationAverage = destination => {
        //            var query = Flights
        //                .Where(f => f.Destination.Equals(destination))
        //                .Average(f => f.EstimateDuration);
        //            return query;
        //        };

        //    // ...
        //}

      
        

       


    }
}

