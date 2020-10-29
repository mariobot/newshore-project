using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewShore.Domain.Model
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required]
        public string NamePasanger { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailContact { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }        
    }
}
