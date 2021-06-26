using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimDeskCore.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Technician> Technicians  { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(new Client
            {
                Id = 1,
                FirstName = "Charles",
                LastName = "Xavier",
                PhoneNumber= "332-333-1399",
                Email = "charles@xavierschool.edu",
                AddressLine1 = "3341 University Ave",
                City = "Utica",
                State = "NY",
                ZipCode = "10108"
            });

            modelBuilder.Entity<Technician>().HasData(new Technician
            {
                Id = 1,
                FirstName = "Morris",
                LastName = "Moss",
                PhoneNumber = "819-847-2185",
                Email = "moss@itsolutions.net",
                AddressLine1 = "737 Renholm St",
                City = "London",
                State = "MA",
                ZipCode = "37662"
            });

            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                Id = 1,
                Description = "Cerebro is down again.",
                TechnicianId = 1,
                ClientId = 1
            });

            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                Id = 1,
                TicketId = 1,
                Description = "Turned it off and back on again.",
                TechnicianId = 1
            }) ;
        }
        
    }
}
