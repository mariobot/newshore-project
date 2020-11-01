using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewShore.Domain.DTO;
using NewShore.Domain.Mapper;
using NewShore.UI.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace NewShore.UI.Controllers
{
    public class TicketController : Controller
    {
        private readonly HttpClient clientHttp;
        private readonly ILogger<TicketController> logger;

        public TicketController(IHttpClientFactory clientHttp, ILogger<TicketController> logger)
        {
            this.clientHttp = clientHttp.CreateClient("apiClient");
            this.logger = logger;
        }

        // GET: TicketController
        public ActionResult Index()
        {
            return View(null);
        }

        /// <summary>
        /// Functionality to search a reservation by reserve number
        /// </summary>
        /// <param name="FlightNumber">Number of the reserve</param>
        /// <returns>Ticket Detail</returns>
        [HttpGet]
        public async Task<ActionResult> SearchReserve(string FlightNumber)
        {
            if (!string.IsNullOrEmpty(FlightNumber))
            {
                logger.LogInformation($"Busqueda de la reserva: {FlightNumber}");
                var response = await clientHttp.GetFromJsonAsync<TicketDetailDTO>($"api/ticket/{FlightNumber}");
                return View("Index", response);
            }
            else {
                logger.LogInformation($"Busqueda de la reserva nula: {FlightNumber}");
                return View("Index", null);
            }            
        }

        // GET: TicketController/Create
        public ActionResult Create(int Id)
        {
            TicketModel ticketModel = new TicketModel(){FlightId = Id};
            return View(ticketModel);
        }

        /// <summary>
        /// POST: TicketController/Create 
        /// Functionality to create te reservation with the basic information. 
        /// </summary>
        /// <param name="ticketModel">Model with customer information</param>
        /// <returns>Redirecto to reserveSearch</returns>
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
                    logger.LogInformation("Reserva creada al cliente", ticketModel);
                    return RedirectToAction("SearchReserve", "Ticket", new { FlightNumber });
                }
                else {
                    return View("Create", ticketModel);
                }                
            }
            catch (System.Exception ex)
            {
                logger.LogError(ex, "Ha ocurrido un error al momento de hacer la reserva", ticketModel);
                return View("Index");
            }
        }
    }
}
