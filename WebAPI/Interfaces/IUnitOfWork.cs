using System.Threading.Tasks;

namespace WebAPI.Interfaces
{
    public interface IUnitOfWork
    {
        ICityReposetory CityReposetory { get; }
        Task<bool> SaveAsync();
    }
}
