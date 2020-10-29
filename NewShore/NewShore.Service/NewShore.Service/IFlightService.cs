using NewShore.Domain.DTO;
using System.Collections.Generic;

namespace NewShore.Service
{
    public interface IFlightService
    {
        List<FlightDTO> SearchFight(FlightQueryDTO flightQuery);
    }
}