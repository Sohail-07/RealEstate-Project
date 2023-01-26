using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IUserReposetory
    {
        Task<User> Authenticate(string username, string password);
    }
}
