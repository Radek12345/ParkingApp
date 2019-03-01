using System.Threading.Tasks;
using ParkingApp.API.Core;

namespace ParkingApp.API.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ParkingDbContext context;

        public UnitOfWork(ParkingDbContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}