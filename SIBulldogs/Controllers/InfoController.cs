using Microsoft.AspNetCore.Mvc;
using SIBulldogs.Models;
using System.Diagnostics;

namespace SIBulldogs.Controllers;

public class InfoController : Controller   {

    // Redirect Index to About
    public IActionResult Index()
    {
        ViewBag.Message = "About";
        return View();
    }

    // Our Views
    public IActionResult About()
    {
        ViewBag.Message = "About";            
        return View("Index");
    }
   
    public IActionResult TOS()
    {
        ViewBag.Message = "TOS";
        return View();
    }
    public IActionResult Privacy()
    {
        ViewBag.Message = "Privacy";
        return View();
    }
   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
