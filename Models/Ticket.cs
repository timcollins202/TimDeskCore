using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TimDeskCore.Models
{
    public class Ticket
    {
        public Ticket()
        {
            DateSubmitted = DateTime.Now;
            DateClosed = null;
            TicketStatus = Status.Open.ToString();
            /*
            IEnumerable<Activity> query = Activities.Where(activity => activity.TicketId == Id);
            foreach (Activity result in query)
            {
                Activities.Add(result);
            }
            */
        }
        enum Status { Open, InProgress, SolutionPending, Closed }
        public int Id { get; set; }
        public DateTime DateSubmitted { get; set; }
        public DateTime? DateClosed { get; set; }
        public string Description { get; set; }
        //public Technician Technician { get; set; }
        public int TechnicianId { get; set; }
        public Client RequestedBy { get; set; }
        public int ClientId { get; set; }
        public List<Activity> Activities { get; set; }
        public string  TicketStatus { get; set; }


    }
}
