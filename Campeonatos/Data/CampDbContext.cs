using Campeonatos.Models;
using Microsoft.EntityFrameworkCore;
namespace Campeonatos.Data
{
    public class CampDbContext : DbContext
    {
        public CampDbContext(DbContextOptions<CampDbContext> options)
            : base(options)
        {

        }
        public DbSet<User> Users { get; set; }


    }
}
