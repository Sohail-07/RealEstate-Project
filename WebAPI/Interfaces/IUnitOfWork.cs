using System.Threading.Tasks;

namespace WebAPI.Interfaces
{
    public interface IUnitOfWork
    {
        ICityReposetory CityReposetory { get; }
        IUserReposetory UserReposetory { get; }
        Task<bool> SaveAsync();
    }
}
