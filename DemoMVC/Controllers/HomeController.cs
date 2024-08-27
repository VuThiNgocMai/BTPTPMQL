using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace DemoMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Demo()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Demo (string Fullname)
    {
        string strResult = "Hello" + Fullname;
        ViewBag.thongbao = strResult;
        return View();
    }
   
    public IActionResult Privacy()
    {
        return View();
    }
     public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string Fullname, string Address)
    {
        string strResult = "Hello" + Fullname + "-" + Address;
        ViewBag.Message = strResult; 
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
