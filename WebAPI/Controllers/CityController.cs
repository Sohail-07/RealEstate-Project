using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Dtos;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        
        public CityController(IUnitOfWork uow)
        {
            this.uow = uow;
        }


        [HttpGet]
        public async Task<IActionResult> GetCities()
        {
            var cities = await uow.CityReposetory.GetCitiesAsync();
            var citiesDto = from c in cities
                            select new CityDto
                            {
                                Id = c.Id,
                                Name = c.Name
                            };
            return Ok(citiesDto);
        }
         
        //Post the data in Json format
        [HttpPost("post")]
        public async Task<IActionResult> AddCity(CityDto cityDto)
        {
            var city = new City { 
                Name = cityDto.Name,
                LastUpdatedBy = 1,
                LastUpdatedOn = DateTime.Now
            };
            uow.CityReposetory.AddCity(city);
            await uow.SaveAsync();
            return StatusCode(201);
        }
        
        //Delete record
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteCities(int id)
        {
            uow.CityReposetory.DeleteCity(id);
            await uow.SaveAsync();
            return Ok(id);
        }
    }
}
