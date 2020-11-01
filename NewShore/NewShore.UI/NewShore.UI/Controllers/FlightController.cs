using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewShore.Domain.DTO;
using NewShore.UI.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace NewShore.UI.Controllers
{
    public class FlightController : Controller
    {
        private readonly HttpClient clientHttp;
        private readonly ILogger<FlightController> logger;

        public FlightController(IHttpClientFactory clientHttp, ILogger<FlightController> logger)
        {
            this.clientHttp = clientHttp.CreateClient("apiClient");
            this.logger = logger;
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
            logger.LogInformation("Busqueda de vuelo", queryFlight);
            var response = await clientHttp.PostAsJsonAsync<FlightQueryDTO>("api/flight", queryFlight);
            var json = await response.Content.ReadAsStringAsync();
            modelVM.ListFlights = JsonSerializer.Deserialize<List<FlightDTO>>(json, new JsonSerializerOptions {
                PropertyNameCaseInsensitive = true,});
            return View("Index", modelVM);
        }
    }
}
