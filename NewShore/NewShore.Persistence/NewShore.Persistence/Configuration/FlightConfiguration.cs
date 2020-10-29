using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewShore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewShore.Persistence.Configuration
{
    public class FlightConfiguration
    {
        public FlightConfiguration(EntityTypeBuilder<Flight> entityBuilder)
        {
            var random = new Random();
            var flights = new List<Flight>() {
                new Flight(){ Id=1,DepartureStation="BOG",ArrivalStation="MED",DepartureDate=DateTime.Now.AddHours(12),Currency="COP", Price=random.Next(100000, 300000), TransportId=1},
                new Flight(){ Id=2,DepartureStation="BOG",ArrivalStation="MED",DepartureDate=DateTime.Now.AddHours(14),Currency="COP", Price=random.Next(100000, 300000), TransportId=2},
                new Flight(){ Id=3,DepartureStation="BOG",ArrivalStation="MED",DepartureDate=DateTime.Now.AddHours(17),Currency="COP", Price=random.Next(100000, 300000), TransportId=3},
                new Flight(){ Id=4,DepartureStation="MED",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddHours(12),Currency="COP", Price=random.Next(100000, 300000), TransportId=4},
                new Flight(){ Id=5,DepartureStation="MED",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddHours(15),Currency="COP", Price=random.Next(100000, 300000), TransportId=5},
                new Flight(){ Id=6,DepartureStation="MED",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddHours(17),Currency="COP", Price=random.Next(100000, 300000), TransportId=6},
                new Flight(){ Id=7,DepartureStation="CTG",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddHours(10),Currency="COP", Price=random.Next(100000, 300000), TransportId=7},
                new Flight(){ Id=8,DepartureStation="CTG",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddHours(15),Currency="COP", Price=random.Next(100000, 300000), TransportId=8},
                new Flight(){ Id=9,DepartureStation="BOG",ArrivalStation="CTG",DepartureDate=DateTime.Now.AddHours(14),Currency="COP", Price=random.Next(100000, 300000), TransportId=9},
                new Flight(){ Id=10,DepartureStation="BOG",ArrivalStation="CTG",DepartureDate=DateTime.Now.AddHours(17),Currency="COP", Price=random.Next(100000, 300000), TransportId=10},
                new Flight(){ Id=11,DepartureStation="BOG",ArrivalStation="PEI",DepartureDate=DateTime.Now.AddHours(10),Currency="COP", Price=random.Next(100000, 300000), TransportId=11},
                new Flight(){ Id=12,DepartureStation="BOG",ArrivalStation="PEI",DepartureDate=DateTime.Now.AddHours(16),Currency="COP", Price=random.Next(100000, 300000), TransportId=12},
                new Flight(){ Id=13,DepartureStation="PEI",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddHours(10),Currency="COP", Price=random.Next(100000, 300000), TransportId=13},
                new Flight(){ Id=14,DepartureStation="PEI",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddHours(17),Currency="COP", Price=random.Next(100000, 300000), TransportId=14},

                new Flight(){ Id=15,DepartureStation="BOG",ArrivalStation="MED",DepartureDate=DateTime.Now.AddDays(1).AddHours(12),Currency="COP", Price=random.Next(100000, 300000), TransportId=15},
                new Flight(){ Id=16,DepartureStation="BOG",ArrivalStation="MED",DepartureDate=DateTime.Now.AddDays(1).AddHours(14),Currency="COP", Price=random.Next(100000, 300000), TransportId=16},
                new Flight(){ Id=17,DepartureStation="BOG",ArrivalStation="MED",DepartureDate=DateTime.Now.AddDays(1).AddHours(17),Currency="COP", Price=random.Next(100000, 300000), TransportId=17},
                new Flight(){ Id=18,DepartureStation="MED",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddDays(1).AddHours(12),Currency="COP", Price=random.Next(100000, 300000), TransportId=18},
                new Flight(){ Id=19,DepartureStation="MED",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddDays(1).AddHours(15),Currency="COP", Price=random.Next(100000, 300000), TransportId=19},
                new Flight(){ Id=20,DepartureStation="MED",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddDays(1).AddHours(17),Currency="COP", Price=random.Next(100000, 300000), TransportId=20},
                new Flight(){ Id=21,DepartureStation="CTG",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddDays(1).AddHours(10),Currency="COP", Price=random.Next(100000, 300000), TransportId=21},
                new Flight(){ Id=22,DepartureStation="CTG",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddDays(1).AddHours(15),Currency="COP", Price=random.Next(100000, 300000), TransportId=22},
                new Flight(){ Id=23,DepartureStation="BOG",ArrivalStation="CTG",DepartureDate=DateTime.Now.AddDays(1).AddHours(14),Currency="COP", Price=random.Next(100000, 300000), TransportId=23},
                new Flight(){ Id=24,DepartureStation="BOG",ArrivalStation="CTG",DepartureDate=DateTime.Now.AddDays(1).AddHours(17),Currency="COP", Price=random.Next(100000, 300000), TransportId=24},
                new Flight(){ Id=25,DepartureStation="BOG",ArrivalStation="PEI",DepartureDate=DateTime.Now.AddDays(1).AddHours(10),Currency="COP", Price=random.Next(100000, 300000), TransportId=25},
                new Flight(){ Id=26,DepartureStation="BOG",ArrivalStation="PEI",DepartureDate=DateTime.Now.AddDays(1).AddHours(16),Currency="COP", Price=random.Next(100000, 300000), TransportId=26},
                new Flight(){ Id=27,DepartureStation="PEI",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddDays(1).AddHours(10),Currency="COP", Price=random.Next(100000, 300000), TransportId=27},
                new Flight(){ Id=28,DepartureStation="PEI",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddDays(1).AddHours(17),Currency="COP", Price=random.Next(100000, 300000), TransportId=28},

                new Flight(){ Id=29,DepartureStation="BOG",ArrivalStation="MED",DepartureDate=DateTime.Now.AddDays(2).AddHours(12),Currency="COP", Price=random.Next(100000, 300000), TransportId=29},
                new Flight(){ Id=30,DepartureStation="BOG",ArrivalStation="MED",DepartureDate=DateTime.Now.AddDays(2).AddHours(14),Currency="COP", Price=random.Next(100000, 300000), TransportId=30},
                new Flight(){ Id=31,DepartureStation="BOG",ArrivalStation="MED",DepartureDate=DateTime.Now.AddDays(2).AddHours(17),Currency="COP", Price=random.Next(100000, 300000), TransportId=31},
                new Flight(){ Id=32,DepartureStation="MED",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddDays(2).AddHours(12),Currency="COP", Price=random.Next(100000, 300000), TransportId=32},
                new Flight(){ Id=33,DepartureStation="MED",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddDays(2).AddHours(15),Currency="COP", Price=random.Next(100000, 300000), TransportId=33},
                new Flight(){ Id=34,DepartureStation="MED",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddDays(2).AddHours(17),Currency="COP", Price=random.Next(100000, 300000), TransportId=34},
                new Flight(){ Id=35,DepartureStation="CTG",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddDays(2).AddHours(10),Currency="COP", Price=random.Next(100000, 300000), TransportId=35},
                new Flight(){ Id=36,DepartureStation="CTG",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddDays(2).AddHours(15),Currency="COP", Price=random.Next(100000, 300000), TransportId=36},
                new Flight(){ Id=37,DepartureStation="BOG",ArrivalStation="CTG",DepartureDate=DateTime.Now.AddDays(2).AddHours(14),Currency="COP", Price=random.Next(100000, 300000), TransportId=37},
                new Flight(){ Id=38,DepartureStation="BOG",ArrivalStation="CTG",DepartureDate=DateTime.Now.AddDays(2).AddHours(17),Currency="COP", Price=random.Next(100000, 300000), TransportId=38},
                new Flight(){ Id=39,DepartureStation="BOG",ArrivalStation="PEI",DepartureDate=DateTime.Now.AddDays(2).AddHours(10),Currency="COP", Price=random.Next(100000, 300000), TransportId=39},
                new Flight(){ Id=40,DepartureStation="BOG",ArrivalStation="PEI",DepartureDate=DateTime.Now.AddDays(2).AddHours(16),Currency="COP", Price=random.Next(100000, 300000), TransportId=40},
                new Flight(){ Id=41,DepartureStation="PEI",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddDays(2).AddHours(10),Currency="COP", Price=random.Next(100000, 300000), TransportId=41},
                new Flight(){ Id=42,DepartureStation="PEI",ArrivalStation="BOG",DepartureDate=DateTime.Now.AddDays(2).AddHours(17),Currency="COP", Price=random.Next(100000, 300000), TransportId=42},
            };

            entityBuilder.HasData(flights);
        }
    }
}
