using Microsoft.AspNetCore.Mvc;

namespace Firtmvc.Controllers;

public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string fname, string email)
    {
        string strResult = "Xin chao : " + fname.ToUpper() + " - " + email;
        ViewBag.Nhandulieu = strResult;
        return View();
    }

}