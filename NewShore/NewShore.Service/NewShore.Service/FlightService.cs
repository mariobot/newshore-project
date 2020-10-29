using NewShore.Domain.DTO;
using NewShore.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewShore.Service
{
    public class FlightService : IFlightService
    {
        private readonly ApplicationDbContext context;

        public FlightService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<FlightDTO> SearchFight(FlightQueryDTO flightQuery)
        {
            var flight = (from f in context.Flights
                          where f.DepartureStation == flightQuery.Origin &&
                          f.ArrivalStation == flightQuery.Destination &&
                          f.DepartureDate >= flightQuery.From && f.DepartureDate < flightQuery.From.AddDays(1)
                          select new FlightDTO
                          {
                              Id = f.Id,
                              ArrivalStation = f.ArrivalStation,
                              Currency = f.Currency,
                              DepartureDate = f.DepartureDate,
                              DepartureStation = f.DepartureStation,
                              Price = f.Price,
                              TransportId = f.TransportId
                          }).ToList();

            return flight;
        }
    }
}
