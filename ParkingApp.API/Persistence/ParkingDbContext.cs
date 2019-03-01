using Microsoft.EntityFrameworkCore;
using ParkingApp.API.Core.Domain;

namespace ParkingApp.API.Persistence
{
    public class ParkingDbContext : DbContext
    {
        public ParkingDbContext(DbContextOptions<ParkingDbContext> options) : base(options) {}

        public DbSet<ParkingArea> ParkingAreas { get; set; }
    }
}