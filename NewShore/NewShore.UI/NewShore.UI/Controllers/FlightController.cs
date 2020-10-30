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

        // GET: FlightController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FlightController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}
