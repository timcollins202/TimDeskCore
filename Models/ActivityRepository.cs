using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimDeskCore.Models
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly AppDbContext _appDbContext;

        public ActivityRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Activity> AllActivities => _appDbContext.Activities;

        
    }
}
