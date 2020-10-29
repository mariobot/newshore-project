using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewShore.Domain.DTO;
using NewShore.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NewShore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IFlightService flightService;

        public FlightController(IFlightService flightService)
        {
            this.flightService = flightService;
        }

        // GET: api/<FlightController>
        [HttpGet]
        public string Get()
        {
            return "API Flight is RUNNING...";
        }        

        // POST api/<FlightController>
        [HttpPost]
        public List<FlightDTO> Post(FlightQueryDTO flightQuery)
        {
            var result = flightService.SearchFight(flightQuery);
            return result;
        }
    }
}
