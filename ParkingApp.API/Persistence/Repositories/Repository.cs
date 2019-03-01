using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParkingApp.API.Core.Repositories;

namespace ParkingApp.API.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ParkingDbContext context;

        public Repository(ParkingDbContext context)
        {
            this.context = context;
        }

        public async virtual Task<IEnumerable<T>> GetAll()
        {
            return await context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async virtual Task<T> Get(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }
    }
}