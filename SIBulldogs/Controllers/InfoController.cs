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
    public IActionResult Contact()
    {
        ViewBag.Message = "Contact";                       
        return View();
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
    public IActionResult Calendar()        
    {
        ViewBag.Message = "Calendar";            
        return View();
    }
     public IActionResult Fundraise()
    {
        ViewBag.Message = "Fundraise";
        return View();
    }
    public IActionResult Bilaws()
    {
        ViewBag.Message = "Bilaws";
        return View();
    }
    public IActionResult ClubInfo()
    {
        ViewBag.Message = "ClubInfo";
        return View();
    }
     public IActionResult Minutes()
    {
        ViewBag.Message = "Minutes";
        return View();
    }
     public IActionResult Flier()
    {
        ViewBag.Message = "Flier";
        return View();
    }
    public IActionResult TrackWrestling()
    {
        ViewBag.Message = "TrackWrestling";
        return View();
    }
    //public IActionResult ClubBanner()
    //{
    //    ViewBag.Message = "ClubBanner";
    //    return View();
    //}

    public IActionResult Test()
    {
        ViewBag.Message = "Test";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
