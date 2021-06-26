using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimDeskCore.Models;
using TimDeskCore.ViewModels;

namespace TimDeskCore.Controllers
{
    public class TicketController : Controller
    {
        public readonly ITicketRepository _ticketRepository;
        public readonly IClientRepository _clientRepository;
        public readonly ITechnicianRepository _technicianRepository;

        public TicketController(ITicketRepository ticketRepository, IClientRepository clientRepository, ITechnicianRepository technicianRepository)
        {
            _ticketRepository = ticketRepository;
            _clientRepository = clientRepository;
            _technicianRepository = technicianRepository;
        }

        public IActionResult Index()
        {
            var tickets = _ticketRepository.AllTickets.ToList();
            var ticketViewModels = new List<TicketViewModel>();

            foreach (Ticket ticket in tickets)
            {
                //TODO: map ticket to ticketviewmodels, then finish the ticket index view.
            }

            return View(ticketViewModels);
        }
    }
}
