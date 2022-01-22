using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World", "text/html");
        }
        public IActionResult Goodbye()
        {
            return Content("<h1>Hello World</h1>", "text/html");
        }
    }
}
