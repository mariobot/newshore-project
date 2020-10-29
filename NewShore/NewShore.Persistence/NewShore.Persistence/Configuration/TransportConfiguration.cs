using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewShore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewShore.Persistence.Configuration
{
    public class TransportConfiguration
    {
        public TransportConfiguration(EntityTypeBuilder<Transport> entityBuilder)
        {
            var transports = new List<Transport>();
            for (int i = 1; i <= 42; i++)
            {
                Transport t = new Transport()
                {
                    Id = i,
                    FlightNumber = $"{GetLetter().ToString().ToUpper()}{GetLetter().ToString().ToUpper()}{GetLetter().ToString().ToUpper()}{GetLetter().ToString().ToUpper()}{GetLetter().ToString().ToUpper()}{GetLetter().ToString().ToUpper()}{GetLetter().ToString().ToUpper()}"
                };
                transports.Add(t);
            }

            entityBuilder.HasData(transports);
        }

        static Random _random = new Random();
        public static char GetLetter()
        {            
            int num = _random.Next(0, 26); 
            char let = (char)('a' + num);
            return let;
        }
    }
}
