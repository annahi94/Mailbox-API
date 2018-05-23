using MailboxAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace MailboxAPI.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions opts) : base(opts)
        {
           
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Area> Areas { get; set; }
    }
}
