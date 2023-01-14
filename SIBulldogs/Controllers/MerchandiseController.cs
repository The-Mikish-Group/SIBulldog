using Microsoft.AspNetCore.Mvc;
namespace SIBulldogs.Controllers;

public class MerchandiseController : Controller
{

    // Redirect Index to Store
    public IActionResult Index()
    {
        ViewBag.Message = "Store";
        return View("Store");
    }

    // Our Views
    public IActionResult Store()
    {
        ViewBag.Message = "Store";
        return View();
    }
}
