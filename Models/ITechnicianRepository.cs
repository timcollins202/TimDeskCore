using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimDeskCore.Models
{
    public interface ITechnicianRepository
    {
        public IEnumerable<Technician> AllTechnicians { get; }
    }
}
