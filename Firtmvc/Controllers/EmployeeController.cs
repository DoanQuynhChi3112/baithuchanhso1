using Microsoft.AspNetCore.Mvc;

namespace Firtmvc.Controllers;

public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string fname, string ID, string Age)
    {
        string strResult = "Xin chao : " + fname.ToUpper() + " - " + ID + "-" + Age;
        ViewBag.Nhandulieu = strResult;
        return View();
    }

}