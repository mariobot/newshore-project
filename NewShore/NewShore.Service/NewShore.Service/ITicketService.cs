using NewShore.Domain.DTO;
using System.Threading.Tasks;

namespace NewShore.Service
{
    public interface ITicketService
    {
        Task<string> CreateTicket(TicketDTO ticket);
        TicketDetailDTO GetTicket(string FlightNumber);
    }
}