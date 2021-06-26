using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimDeskCore.Models
{
    public interface IActivityRepository
    {
        public IEnumerable<Activity> AllActivities { get; }
    }
}
