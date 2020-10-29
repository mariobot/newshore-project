using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NewShore.Domain.Model
{
    public class Flight
    {
        public int Id { get; set; }
        
        public string DepartureStation { get; set; }
        
        public string ArrivalStation { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DepartureDate { get; set; }
        public int TransportId { get; set; }
        public Transport Transport { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        
        public string Currency { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
