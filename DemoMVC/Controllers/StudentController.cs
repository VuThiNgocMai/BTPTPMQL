using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace DemoMVC.Controllers;
public class StudentController : Controller 
{
    public IActionResult Index()
    {
        return View();
 
    }
    [HttpPost]
    public IActionResult Index(Student std)
    {
        string strOutput = "Xin chao" + std.Fullname + "-" + std.Address;
        ViewBag.thongbao = strOutput;
        return View();
 
    }
}
