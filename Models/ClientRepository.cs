using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimDeskCore.Models
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _appDbContext;

        public ClientRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Client> AllClients => _appDbContext.Clients;

        public Client GetClientById(int id)
        {
            return _appDbContext.Clients.FirstOrDefault(c => c.Id == id);
        }
    }
}
