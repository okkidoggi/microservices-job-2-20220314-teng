using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taxi_Booking_API.Models
{
    public class Booking
    {

        public long Id { get; set; }
        public string DateTime { get; set; }
        public string PickupPoint { get; set; }
        public string Destination { get; set; }
        public double CurrentLocationLatitude { get; set; }
        public double CurrentLocationLongitude { get; set; }
    }
}


