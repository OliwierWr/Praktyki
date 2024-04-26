using Microsoft.EntityFrameworkCore;

using WebApplication6.Models;

namespace WebApplication6.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Klienci> Klient { get; set; }

       
    }
}
