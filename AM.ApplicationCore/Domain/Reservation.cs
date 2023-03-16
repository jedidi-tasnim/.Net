﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Reservation
    {
        public DateTime DateReservation { get; set; }
        public virtual Seat seat { get; set; }
        public virtual Passenger passenger { get; set; }

       // [ForeignKey(nameof(Passenger))] 
        public int PassengerFK { get; set; }
       // [ForeignKey(nameof(Seat))] 
        public int SeatFK { get; set; }

    }
}
