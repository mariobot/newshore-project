using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewShore.Domain.DTO;

namespace NewShore.UI.Controllers
{
    public class TicketController : Controller
    {
        private readonly HttpClient clientHttp;
        public TicketController(IHttpClientFactory clientHttp)
        {
            this.clientHttp = clientHttp.CreateClient("apiClient");
        }

        // GET: TicketController
        public ActionResult Index()
        {
            return View(null);
        }

        [HttpGet]
        public async Task<ActionResult> SearchReserve(string FlightNumber)
        {
            if (!string.IsNullOrEmpty(FlightNumber))
            {
                var response = await clientHttp.GetFromJsonAsync<TicketDetailDTO>($"api/ticket/{FlightNumber}");
                return View("Index", response);
            }
            else {
                return View("Index", null);
            }            
        }

        // GET: TicketController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TicketController/Create
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

        // GET: TicketController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TicketController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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
    }
}
