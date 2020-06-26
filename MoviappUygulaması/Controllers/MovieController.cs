using Microsoft.AspNetCore.Mvc;
using MoviappUygulaması.Models;

namespace MoviappUygulaması.Controllers
{
    public class Movie : Controller
    {
        // GET
        public virtual IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(MovieRepository.Movies);
        }
    }
}