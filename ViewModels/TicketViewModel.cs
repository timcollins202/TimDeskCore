using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimDeskCore.Models;

namespace TimDeskCore.ViewModels
{
    public class TicketViewModel
    {
        public IEnumerable<Ticket> Tickets { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Technician> Technicians { get; set; }
    }
}
