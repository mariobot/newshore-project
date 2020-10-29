using NewShore.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewShore.Service
{
    public class FlightService
    {
        private readonly ApplicationDbContext context;

        public FlightService(ApplicationDbContext context)
        {
            this.context = context;
        }
    }
}
