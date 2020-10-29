using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewShore.Domain.DTO;
using NewShore.Service;

namespace NewShore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService ticketService;

        public TicketController(ITicketService ticketService)
        {
            this.ticketService = ticketService;
        }

        // GET: api/<TicketController>
        [HttpGet]
        public string Get()
        {
            return "API Ticket is RUNNING...";
        }

        // GET api/<TicketController>/5
        [HttpGet("{flightNumber}")]
        public TicketDetailDTO Get(string flightNumber)
        {
            return ticketService.GetTicket(flightNumber);
        }

        // POST api/<TicketController>
        [HttpPost]
        public async Task Post(TicketDTO ticket)
        {
            await ticketService.CreateTicket(ticket);
        }
    }
}
