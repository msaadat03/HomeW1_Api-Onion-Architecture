using Api_Intro.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Intro.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Group> groups = new List<Group>();

            Group group1 = new()
            {
                Id = 1,
                Name = "P130",
                Capacity = 16
            };

            Group group2 = new()
            {
                Id = 2,
                Name = "P135",
                Capacity = 20
            };

            Group group3 = new()
            {
                Id = 3,
                Name = "P414",
                Capacity = 18
            };

            groups.Add(group1);
            groups.Add(group2);
            groups.Add(group3);

            return Ok(groups);
        }
    }
}
