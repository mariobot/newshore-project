using System;
using System.Collections.Generic;
using System.Text;

namespace NewShore.Domain.DTO
{
    public class TicketDetailDTO
    {
        public int Id { get; set; }
        public string NamePasanger { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailContact { get; set; }
        public int FlightId { get; set; }
        public FlightDTO Flight { get; set; }
        public string FlightNumber { get; set; }
    }
}
