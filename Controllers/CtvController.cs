using Microsoft.AspNetCore.Mvc;

namespace Site.Controllers;

public class CtvController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
