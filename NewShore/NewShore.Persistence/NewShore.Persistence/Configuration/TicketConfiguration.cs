using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewShore.Domain.Model;
using System.Collections.Generic;

namespace NewShore.Persistence.Configuration
{
    public class TicketConfiguration
    {
        public TicketConfiguration(EntityTypeBuilder<Ticket> entityBuilder)
        {
            var tickets = new List<Ticket>() {
                new Ticket(){ Id=1,NamePasanger="Mario Botero", EmailContact="mariobot@hotmail.com",PhoneNumber="5764821565", FlightId=10},
                new Ticket(){ Id=2,NamePasanger="Carolina gomez", EmailContact="cmejia@hotmail.com",PhoneNumber="5732456215", FlightId=20},
                new Ticket(){ Id=3,NamePasanger="Maria Mejia", EmailContact="mmejia@gmail.com",PhoneNumber="5755662245", FlightId=30},
                new Ticket(){ Id=4,NamePasanger="Fernanda Ferrero", EmailContact="fernando23@gmail.com",PhoneNumber="57545562", FlightId=40},
                new Ticket(){ Id=5,NamePasanger="Camilo Mejia", EmailContact="cmejia@hotmail.com",PhoneNumber="574455665", FlightId=42},
            };

            entityBuilder.HasData(tickets);                
        }
    }
}
