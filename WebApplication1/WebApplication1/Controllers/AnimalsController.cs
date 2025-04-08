using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    // api/animals => [controller] = Tests
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var animals = Database.Animals;
            return Ok(animals);
        }
        // animals?id=1 [FromQuery]
        // animals/1 [FromRoute]
        //"names/{id}}"
        [HttpGet("names/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var animals = Database.Animals.FirstOrDefault(x => x.id == id);
            return Ok(animals);
        }
    }
}
