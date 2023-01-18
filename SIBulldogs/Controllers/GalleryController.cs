using Microsoft.AspNetCore.Mvc;
using SIBulldogs.Models;
using System.Diagnostics;

namespace SIBulldogs.Controllers;

public class GalleryController : Controller {

    // Redirect Index to Gallery
    public IActionResult Index()
    {
        ViewBag.Message = "Gallery";
        return View("Gallery");
    }

    // Our Views
    public IActionResult Gallery()
    {
        ViewBag.Message = "Gallery";
        return View();
    }
    public IActionResult Pictures01()
    {
        ViewBag.Message = "Pictures01";
        return View();
    }
    public IActionResult Pictures02()
    {
        ViewBag.Message = "Pictures02";
        return View();
    }
    public IActionResult Pictures03()
    {
        ViewBag.Message = "Pictures03";
        return View();
    }
    public IActionResult Pictures04()
    {
        ViewBag.Message = "Pictures04";
        return View();
    }
    public IActionResult Pictures05()
    {
        ViewBag.Message = "Pictures05";
        return View();
    }
    public IActionResult Pictures06()
    {
        ViewBag.Message = "Pictures06";
        return View();
    }
    public IActionResult Pictures07()
    {
        ViewBag.Message = "Pictures07";
        return View();
    }
    public IActionResult WebArtSVG()
    {
        ViewBag.Message = "WebArtSVG";            
        return View();
    }
    public IActionResult WebArtPNG()
    {
        ViewBag.Message = "WebArtPNG";
        return View();
    }
    public IActionResult WebArtZIP()
    {
        ViewBag.Message = "WebArtZIP";            
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
