using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimDeskCore.Models
{
    public class Activity
    {
        public Activity()
        {
            DateSubmitted = DateTime.Now;
            DateClosed = null;
            ActivityStatus = Status.Open.ToString();
            IsSolution = false;
        }
        enum Status { Open, InProgress, SolutionPending, Closed }
        public int Id { get; set; }
        public int TicketId { get; set; }
        public DateTime DateSubmitted { get; set; }
        public DateTime? DateClosed { get; set; }
        public string Description { get; set; }
        //public Technician Technician { get; set; }
        public int TechnicianId { get; set; }
        public bool IsSolution { get; set; }
        public string ActivityStatus { get; set; }
    }
}
