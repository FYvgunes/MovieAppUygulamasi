using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MoviappUygulaması.Models;

namespace MoviappUygulaması.ViewComponent
{
    public class MenuViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(CategoryRepository.Categories);
        }

        
    }
    
}