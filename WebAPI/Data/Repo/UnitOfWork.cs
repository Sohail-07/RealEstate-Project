using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Data.Repo;

namespace WebAPI.Interfaces
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext dc;

        public UnitOfWork(DataContext dc)
        {
            this.dc = dc;
        }
        public ICityReposetory CityReposetory =>
            new CityReposetory(dc);

        public async Task<bool> SaveAsync()
        {
            return await dc.SaveChangesAsync() > 0;
        }
    }
}
