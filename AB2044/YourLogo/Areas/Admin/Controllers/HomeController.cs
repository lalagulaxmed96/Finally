using Microsoft.AspNetCore.Mvc;

namespace YourLogo.Areas.Admin.Controllers;

public class HomeController : Controller
{

    public  HomeController()
    { 

    }
    public IActionResult Index()
    {
        return View();
    }
}

