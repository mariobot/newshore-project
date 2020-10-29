using System;
using System.Collections.Generic;
using System.Text;

namespace NewShore.Domain.DTO
{
    public class TicketDTO
    {
        public int Id { get; set; }        
        public string NamePasanger { get; set; }        
        public string PhoneNumber { get; set; }
        public string EmailContact { get; set; }
        public int FlightId { get; set; }
    }
}
