using Microsoft.AspNetCore.Mvc;

namespace api_pipelining_practice_project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var user = new
            {
                Id = 1,
                Name = "John Doe",
                Email = "user@gmail.com"
            };

            return Ok(user);
        }

        [HttpGet("add-user")]
        public IActionResult AddUserAsync()
        {
            return Ok(new {Message="User Added Successfully"});
        }
    }
}
