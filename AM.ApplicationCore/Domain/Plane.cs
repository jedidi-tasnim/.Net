using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        [Range(0,int.MaxValue)]
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int Planeid { get; set; }
        public PlaneType PlaneType { get; set; }
        public List<Flight> flights { get; set; }

        public override string ToString()
        {
            return (Capacity + "\n" +
                " " + ManufactureDate + " " + Planeid + "" + PlaneType + "" );

        }
        public Plane()
        {

        }
        //public Plane(PlaneType pt, int capacity, DateTime date)
       // {
         //   Capacity = capacity;
           // ManufactureDate = date;
            //PlaneType = pt;
            
      //  }
    }
}
