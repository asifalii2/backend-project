using Microsoft.AspNetCore.Mvc;

namespace api_pipelining_practice_project.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
