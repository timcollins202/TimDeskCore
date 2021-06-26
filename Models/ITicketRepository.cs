using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimDeskCore.Models
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> AllTickets { get; }

        Ticket GetTicketById(int ticketId);
    }
}
