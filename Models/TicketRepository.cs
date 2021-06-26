using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimDeskCore.Models
{
    public class TicketRepository : ITicketRepository
    {
        private readonly AppDbContext _appDbContext;

        public TicketRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Ticket> AllTickets
        {
            get
            {
                return _appDbContext.Tickets.Include(a => a.Activities);
            }
        }

        public Ticket GetTicketById(int ticketId)
        {
            return _appDbContext.Tickets.FirstOrDefault(t => t.Id == ticketId);
        }

        public IEnumerable<Ticket> OpenTickets
        {
            get
            {
                return _appDbContext.Tickets.Include(t => t.TicketStatus == "Open");
            }
            
        }
    }
}
