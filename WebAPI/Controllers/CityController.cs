using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Data.Repo;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityReposetory repo;
        public CityController(DataContext dc, ICityReposetory repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetCities()
        {
            var cities = await repo.GetCitiesAsync();
            return Ok(cities);
        }
        
        //Post the data in Json format
        [HttpPost("post")]
        public async Task<IActionResult> AddCities(City city)
        {

           repo.AddCity(city);
            await repo.SaveAsync();
            return StatusCode(201);
        }
        //Delete record
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteCities(int id)
        {
            repo.DeleteCity(id);
            await repo.SaveAsync();
            return Ok(id);
        }
    }
}
