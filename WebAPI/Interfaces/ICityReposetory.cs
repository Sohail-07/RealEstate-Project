using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface ICityReposetory
    {
        Task<IEnumerable<City>> GetCitiesAsync();
        void AddCity(City city);    
        void DeleteCity(int CityId);
    }
}
