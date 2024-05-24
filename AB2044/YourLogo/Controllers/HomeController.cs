using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace YourLogo.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}

