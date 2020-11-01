using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;
using NewShore.Domain.DTO;
using NewShore.UI.Models;
using System.Text.Json;

namespace NewShore.UI.Controllers
{
    public class FlightController : Controller
    {
        private readonly HttpClient clientHttp;

        public FlightController(IHttpClientFactory clientHttp)
        {
            this.clientHttp = clientHttp.CreateClient("apiClient");
        }

        // GET: FlightController
        public ActionResult Index()
        {
            return View(new FlightViewModel());
        }

        /// <summary>
        /// This method call the API to execute te query about the flights
        /// </summary>
        /// <param name="queryFlight">Entity with the parameters</param>
        /// <returns>List of flights</returns>
        [HttpPost]
        public async Task<ActionResult> SearchFlight(FlightQueryDTO queryFlight)
        {
            FlightViewModel modelVM = new FlightViewModel();
            var response = await clientHttp.PostAsJsonAsync<FlightQueryDTO>("api/flight", queryFlight);
            var json = await response.Content.ReadAsStringAsync();
            modelVM.ListFlights = JsonSerializer.Deserialize<List<FlightDTO>>(json, new JsonSerializerOptions {
                PropertyNameCaseInsensitive = true,});
            return View("Index", modelVM);
        }
    }
}
