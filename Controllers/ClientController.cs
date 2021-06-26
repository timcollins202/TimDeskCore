using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimDeskCore.Models;
using TimDeskCore.ViewModels;

namespace TimDeskCore.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public IActionResult Index()
        {
            var clientViewModel = new ClientViewModel();
            clientViewModel.Clients = _clientRepository.AllClients;

            return View(clientViewModel);
        }
    }
}
