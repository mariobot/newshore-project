using Microsoft.EntityFrameworkCore;
using NewShore.Domain.DTO;
using NewShore.Domain.Mapper;
using NewShore.Domain.Model;
using NewShore.Persistence;
using System.Linq;
using System.Threading.Tasks;

namespace NewShore.Service
{
    public class TicketService : ITicketService
    {
        private readonly ApplicationDbContext context;

        public TicketService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task CreateTicket(TicketDTO ticket)
        {
            Ticket _ticket = ticket.MapTo<Ticket>();
            context.Add(_ticket);
            await context.SaveChangesAsync();
        }

        public TicketDetailDTO GetTicket(string FlightNumber)
        {
            var flight = (from c in context.Tickets.AsNoTracking()
                          where c.Flight.Transport.FlightNumber == FlightNumber
                          select new TicketDetailDTO
                          {
                              NamePasanger = c.NamePasanger,
                              EmailContact = c.EmailContact,
                              PhoneNumber = c.PhoneNumber,
                              Id = c.Id,
                              FlightId = c.FlightId,
                              FlightNumber = c.Flight.Transport.FlightNumber,
                              Flight = new FlightDTO
                              {
                                  Id = c.Flight.Id,
                                  ArrivalStation = c.Flight.ArrivalStation,
                                  DepartureDate = c.Flight.DepartureDate,
                                  Currency = c.Flight.Currency,
                                  DepartureStation = c.Flight.DepartureStation,
                                  Price = c.Flight.Price,
                                  TransportId = c.Flight.TransportId
                              }
                          }).FirstOrDefault();

            return flight;
        }
    }
}
