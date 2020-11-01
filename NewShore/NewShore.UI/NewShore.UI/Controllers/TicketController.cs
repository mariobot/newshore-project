using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewShore.Domain.DTO;
using NewShore.UI.Models;
using NewShore.Domain.Mapper;

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
        public ActionResult Create(int Id)
        {
            TicketModel ticketModel = new TicketModel()
            {
                FlightId = Id
            };

            return View(ticketModel);
        }

        // POST: TicketController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(TicketModel ticketModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TicketDTO ticketDTO = ticketModel.MapTo<TicketDTO>();
                    var response = await clientHttp.PostAsJsonAsync<TicketDTO>("api/ticket", ticketDTO);
                    var FlightNumber = await response.Content.ReadAsStringAsync();                    
                    return RedirectToAction("SearchReserve", "Ticket", new { FlightNumber });
                }
                else {
                    return View("Create", ticketModel);
                }                
            }
            catch
            {
                return View("");
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
