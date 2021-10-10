using CitiesServer.Data;
using CitiesServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : Controller
    {
        private readonly DataContext _context;
        private readonly ILogger<CitiesController> _logger;
        public CitiesController(DataContext context,ILogger<CitiesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Get list of all cities
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<City> Get()
        {
            return _context.Cities;
        }

        [HttpGet("{id}", Name = "Get")]
        public City Get(int id)
        {
            return _context.Cities.FirstOrDefault(c => c.ID == id);
        }

        [HttpPost]
        [Produces("application/json")]
        public City Post([FromBody] City city)
        {
            return new City();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] City city)
        {

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
