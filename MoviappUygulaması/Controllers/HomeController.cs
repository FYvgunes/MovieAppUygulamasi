using Microsoft.AspNetCore.Mvc;

namespace MoviappUygulaması.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}