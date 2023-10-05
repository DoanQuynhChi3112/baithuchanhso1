using Firtmvc.Models;
using Microsoft.AspNetCore.Mvc;
namespace Firtmvc.Controllers

{
    public class StudentController : Controller
    {

        public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    
         public IActionResult Index(Student std)
    {
        string strResult = "Xin chao : " + std.FullName + " - " + std.StudentID + " -- " +  std.Address + " !";
        ViewBag.Nhandulieu = strResult;
        return View();
        
    }
    }
}