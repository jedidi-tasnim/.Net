using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        public static List<Plane> planes { get; set; } = new List<Plane>()
        {
            new Plane()
            {
                Planeid= 1,
                Capacity= 150,
                PlaneType=PlaneType.Boing,
                ManufactureDate=new DateTime(2015, 02, 03)
            },
            new Plane()
            {
                Planeid= 2,
                Capacity= 250,
                PlaneType=PlaneType.Airbus,
                ManufactureDate=new DateTime(2020, 11, 11)
            },

        };


        public static List<Staff> staff { get; set; } = new List<Staff>()
        {
            new Staff()
            {
                FirstName = "captain",
                LastName = "captain",
                EmailAddress="Captain.captain@gmail.com",
                BirthDate=new DateTime(1965, 01, 01),
                EmployementDate=new DateTime(1999, 01, 01),
                Salary="99999"
            },
            new Staff()
            {
                FirstName = "hostess1",
                LastName = "hostess1",
                EmailAddress="Hostess1.hostess1@gmail.com",
                BirthDate=new DateTime(1995, 01, 01),
                EmployementDate=new DateTime(2020, 01, 01),
                Salary="999"
            },
            new Staff()
            {
                FirstName = "hostess2",
                LastName = "hostess2",
                EmailAddress="Hostess2.hostess2@gmail.com",
                BirthDate=new DateTime(1996, 01, 01),
                EmployementDate=new DateTime(2020, 01, 01),
                Salary="999"
            }
        };

        public static List<Traveller> travellers { get; set; } = new List<Traveller>()
        {
           new Traveller()
           {
               FirstName="Travaller1",
               LastName="Travaller1",
               EmailAddress="Travaller1.Travaller1@gmail.com",
               BirthDate=new DateTime(1980, 01, 01),
               HealthInformation="No troubles",
               Nationality="American"
           },
           new Traveller()
           {
               FirstName="Travaller2",
               LastName="Travaller2",
               EmailAddress="Travaller2.Travaller2@gmail.com",
               BirthDate=new DateTime(1981, 01, 01),
               HealthInformation="Some troubles",
               Nationality="French"
           },
           new Traveller()
           {
               FirstName="Travaller3",
               LastName="Travaller3",
               EmailAddress="Travaller3.Travaller3@gmail.com",
               BirthDate=new DateTime(1982, 01, 01),
               HealthInformation="No troubles",
               Nationality="Tunisian"
           },
           new Traveller()
           {
               FirstName="Travaller4",
               LastName="Travaller4",
               EmailAddress="Travaller4.Travaller4@gmail.com",
               BirthDate=new DateTime(1983, 01, 01),
               HealthInformation="Some troubles",
               Nationality="American"
           },
           new Traveller()
           {
               FirstName="Travaller5",
               LastName="Travaller5",
               EmailAddress="Travaller5.Travaller5@gmail.com",
               BirthDate=new DateTime(1984, 01, 01),
               HealthInformation="Some troubles",
               Nationality="Spanish"
           }
        };

        public static List<Flight> flights { get; set; } = new List<Flight>()
        {
            new Flight()
            {
                FlightDate=new DateTime(2022, 01, 01, 15, 10, 10),
                Destination="Paris",
                EffectiveArrival=new DateTime(2022, 01, 01, 17, 10, 10),
                plane = planes[1],
                EstmateDuration="100",
                passengers=new List<Passenger>(travellers)
            },
            new Flight()
            {
                FlightDate=new DateTime(2022, 02, 01, 21, 10, 10),
                Destination="Paris",
                EffectiveArrival=new DateTime(2022, 02, 01, 23, 10, 10),
                plane = planes[0],
                EstmateDuration="105",
            },
            new Flight()
            {
                FlightDate=new DateTime(2022, 03, 01, 5, 10, 10),
                Destination="Paris",
                EffectiveArrival=new DateTime(2022, 03, 01, 6, 40, 10),
                plane = planes[0],
                EstmateDuration="100",
            },
            new Flight()
            {
                FlightDate=new DateTime(2022, 04, 01, 6, 10, 10),
                Destination="Madrid",
                EffectiveArrival=new DateTime(2022, 04, 01, 8, 10, 10),
                plane = planes[0],
                EstmateDuration="130",
            },
            new Flight()
            {
                FlightDate=new DateTime(2022, 05, 01, 17, 10, 10),
                Destination="Madrid",
                EffectiveArrival=new DateTime(2022, 05, 01, 18, 50, 10),
                plane = planes[0],
                EstmateDuration="105",
            }
            ,new Flight()
            {
                FlightDate=new DateTime(2022, 06, 01, 20, 10, 10),
                Destination="Lisbonne",
                EffectiveArrival=new DateTime(2022, 06, 01, 22, 30, 10),
                plane = planes[1],
                EstmateDuration="200",
            }
        };



    }
}
