using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Data.Repo
{
    public class UserReposetory : IUserReposetory
    {
        private readonly DataContext dc;

        public UserReposetory(DataContext dc)
        {
            this.dc = dc;
        }
        public async Task<User> Authenticate(string userName, string password)
        {
            return await dc.Users.FirstOrDefaultAsync(x => x.Username== userName 
                                                        && x.Password == password);
        }
    }
}
