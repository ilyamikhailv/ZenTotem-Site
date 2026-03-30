using Microsoft.AspNetCore.Mvc;

namespace Site.Controllers;

public class InAppController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
