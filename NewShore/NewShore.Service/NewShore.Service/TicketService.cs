using NewShore.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewShore.Service
{
    public class TicketService
    {
        private readonly ApplicationDbContext context;

        public TicketService(ApplicationDbContext context)
        {
            this.context = context;
        }
    }
}
