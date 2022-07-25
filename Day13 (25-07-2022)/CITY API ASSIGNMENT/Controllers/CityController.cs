using Microsoft.AspNetCore.Mvc;

namespace CITY_API_ASSIGNMENT.Controllers
{
    [Controller]
    [Route("Api/[Controller]")]
    public class CityController : ControllerBase
    {
        private readonly ILogger<City> _logger;
        public CityController(ILogger<City> logger)
        {
            _logger = logger;
        }
        private List<City> cities = new List<City>
        {
            new City{ID=1, Name="Lucknow", Description="Capital of UP"},
            new City{ID=2, Name="Delhi", Description="Capital of India"},
            new City{ID=3, Name="Patna", Description="Capital of Bihar"},
            new City{ID=4, Name="Mumbai", Description="Capital of Maharastra"},
            new City{ID=5, Name="Banglore", Description="Capital of Karnataka"},
        };
        [HttpGet]
        public ActionResult ShowAllCities()
        {
            return Ok(cities);
        }
    }
}
