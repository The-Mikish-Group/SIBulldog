using Microsoft.AspNetCore.Mvc;
using SIBulldogs.Models;
using System.Diagnostics;

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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
