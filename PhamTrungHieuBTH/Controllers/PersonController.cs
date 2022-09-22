using Microsoft.AspNetCore.Mvc;
using PhamTrungHieuBTH.Models;
namespace PhamTrungHieuBTH.Controllers
{
   public class PersonController : Controller
   {
     public ActionResult Index()
     {
        List<Person> StdList= new List<Person>
        { 
            new Person { Age = 15, Address = "HaNoi", PhoneNumber = "0964220676" },
            new Person { Age = 18, Address = "HoTay", PhoneNumber = "024246872" },
            new Person { Age = 1, Address = "HaNoi", PhoneNumber = "09865765576" },
            new Person { Age = 5, Address = "PhuTho", PhoneNumber = "09867657656" },
            new Person { Age = 20, Address = "LangSon", PhoneNumber = "0986324156" },
            new Person { Age = 20, Address = "NinhBinh", PhoneNumber = "0986324156" },
        };
          ViewData["Person"] = StdList;
            return View();
     }
     [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Person std)
    {
       ViewBag.thongtin = std.Age + "-" + std.Address + "-" + std.PhoneNumber;
        return View();
    }
   }
}
