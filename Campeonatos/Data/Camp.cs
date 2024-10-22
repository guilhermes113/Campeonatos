using Campeonatos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Campeonatos.Data
{
    public class Camp : IdentityDbContext
    {
        private IConfiguration _configuration;

        public Camp( IConfiguration configuration , DbContextOptions<Camp> options)  : base(options)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TimeUser>().HasKey(af => new
            {
                af.UserID,
                af.TimeID
            });
        }

       
        public DbSet<TimeUser> TimesuUsers{ get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Time> Times { get; set; }
        public DbSet<Gestor> Gestores {get; set; }


    }
}
