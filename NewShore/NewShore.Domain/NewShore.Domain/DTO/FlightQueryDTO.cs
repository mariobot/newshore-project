using System;
using System.Collections.Generic;
using System.Text;

namespace NewShore.Domain.DTO
{
    public class FlightQueryDTO
    {
        public string Origin { get; set; }

        public string Destination { get; set; }

        public DateTime From { get; set; }
    }
}
