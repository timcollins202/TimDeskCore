using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TimDeskCore.Models
{
    public interface IClientRepository
    {
        public IEnumerable<Client> AllClients { get; }
    }
}
