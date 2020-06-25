using Microsoft.AspNetCore.Mvc;
using MoviappUygulaması.Models;

namespace MoviappUygulaması.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View(MovieRepository.Movies);
        }
    }
}