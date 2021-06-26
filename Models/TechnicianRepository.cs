using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimDeskCore.Models
{
    public class TechnicianRepository : ITechnicianRepository
    {
        private readonly AppDbContext _appDbContext;

        public TechnicianRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Technician> AllTechnicians => _appDbContext.Technicians;
    }
}
