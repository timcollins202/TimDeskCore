using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimDeskCore.Models;
using TimDeskCore.ViewModels;

namespace TimDeskCore.Controllers
{
    public class TechnicianController : Controller
    {
        public readonly ITechnicianRepository _technicianRepository;

        public TechnicianController(ITechnicianRepository technicianRepository)
        {
            _technicianRepository = technicianRepository;
        }

        public IActionResult Index()
        {
            var technicianViewModel = new TechnicianViewModel();
            technicianViewModel.Technicians = _technicianRepository.AllTechnicians;

            return View(technicianViewModel);
        }
    }
}
