using System.Threading.Tasks;

namespace ParkingApp.API.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}