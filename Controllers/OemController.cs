using Microsoft.AspNetCore.Mvc;

namespace Site.Controllers;

public class OemController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
