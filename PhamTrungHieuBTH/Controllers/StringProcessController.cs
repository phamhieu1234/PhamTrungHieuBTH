using Microsoft.AspNetCore.Mvc;
using PhamTrungHieuBTH.Models.Proess;
namespace PhamTrungHieuBTH.Controllers;
using System.Text.Encodings.Web;
    public class StringProcessController:Controller
    
     {
    private static readonly StringProcess stringProcess = new StringProcess();
    StringProcess strPro = stringProcess;
      
      public IActionResult Index ()
      {
            return View();
      }
       StringProcess strP = stringProcess;
       public IActionResult LowerUpper()
        {
            return View();
        }
         StringProcess strPr = stringProcess;
        public IActionResult UpperToLower()
        {
            return View();
        }
            StringProcess strp = stringProcess;
        public IActionResult CapitalizeOneFirstCharacter()
        {
            return View();
        }
        StringProcess st = stringProcess;
        public IActionResult CapitalizeFirstCharacter()
        {
            return View();
        }
        StringProcess str = stringProcess;
        public IActionResult RemoveVietnameseAccents()
        {
            return View();
        }
    //acction de nhan du loieu gui lenV
    
    public IActionResult RemoveVietnameseAccents (string strInput)
        {
            string strResult= str.RemoveVietnameseAccents(strInput);
            ViewBag.a= strResult;
            return View();
        }
      [HttpPost]
      public IActionResult Index(string strInput )
      {
        string strResult= strPro.RemoveRemainingWhiteSpace(strInput);
        ViewBag.thongBao= strResult;
        return View();
      }
      [HttpPost]
        public IActionResult LowerUpper(string strInput)
        {
            string strResult = strP.LowerToUpper(strInput);
            ViewBag.b= strResult;
            return View();
        }
        [HttpPost]
        public IActionResult UpperToLower(string strInput)
        {
              string strResult = strPr.UpperToLower(strInput);
            ViewBag.c= strResult;
            return View();
        }
        [HttpPost]
        public IActionResult CapitalizeOneFirstCharacter(string strInput)
        {
             string strResult = str.CapitalizeOneFirstCharacter(strInput);
            ViewBag.d= strResult;
            return View();
        }
        [HttpPost]
        public IActionResult CapitalizeFirstCharacter(string strInput)
        {
             string strResult = strp.CapitalizeFirstCharacter(strInput);
            ViewBag.e= strResult;
            return View();
        }

     }
     