using Microsoft.AspNetCore.Mvc;

namespace Site.Controllers;

public class MobileWebController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
