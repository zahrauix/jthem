using Microsoft.AspNetCore.Mvc;

namespace template_store.Areas.Controllers
{
    [Area("Admin")]
    public class Admin : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
    }
}
