using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions Options):base(Options)
        {
           
        }
        public DbSet<Walk>Wals { get; set; }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region>Regions { get; set; }
    }
}
