using Microsoft.AspNetCore.Mvc;

namespace Api_Intro.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetById(int id)
        {
            string name = "Orxan" + id;
            
            return Ok(name);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<string> names = new List<string>() { "Said", "Emil", "Orxan", "Saadat", "Fidan" };

            return Ok(names);
        }
    }
}
