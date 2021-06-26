using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimDeskCore.Models;

namespace TimDeskCore.ViewModels
{
    public class ClientViewModel
    {
        public IEnumerable<Client> Clients { get; set; }
    }
}
