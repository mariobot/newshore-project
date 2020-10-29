using Microsoft.EntityFrameworkCore;
using NewShore.Domain.Model;
using NewShore.Persistence.Configuration;

namespace NewShore.Persistence
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);            

            ModelConfig(builder);
        }

        private void ModelConfig(ModelBuilder builder)
        {
            new TransportConfiguration(builder.Entity<Transport>());
            new FlightConfiguration(builder.Entity<Flight>());            
            new TicketConfiguration(builder.Entity<Ticket>());
        }
    }
}
