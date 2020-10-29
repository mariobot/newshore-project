using System.Collections;
using System.Collections.Generic;

namespace NewShore.Domain.Model
{
    public class Transport
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }

        public ICollection<Flight> Flights { get; set; }
    }
}
