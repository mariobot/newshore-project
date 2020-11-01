using System.ComponentModel.DataAnnotations;

namespace NewShore.UI.Models
{
    public class TicketModel
    {
        [Required(ErrorMessage ="El nombre es requerido")]
        public string NamePasanger { get; set; }
        [Required(ErrorMessage ="El telefono es requerido")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="El email es requerido")]
        [EmailAddress(ErrorMessage ="Email no valido")]
        public string EmailContact { get; set; }
        public int FlightId { get; set; }
    }
}
