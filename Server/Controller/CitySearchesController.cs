using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeatherApp1.Server.Data;
using WeatherApp1.Shared;

namespace WeatherApp1.Server.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitySearchesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CitySearchesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<CitySearch>>> Get()
        {
            return await _context.CitySearched.OrderBy(c => c.CityName).ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Post(CitySearch city)
        {
            if (!_context.CitySearched.Any(c => c.CityName.ToLower() == city.CityName.ToLower()))
            {
                _context.CitySearched.Add(city);
                await _context.SaveChangesAsync();
            }
            return Ok();
        }
    }
}

