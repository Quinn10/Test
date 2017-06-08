using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            throw new StackOverflowException("This is an error");

            //return View();
        }
                
        public ActionResult About()
        {
            throw new DivideByZeroException("This is a devided by error");

            //{
            //    ViewBag.Message = "Your application description page.";

            //    return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having trouble? Send us a message.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            // TODO : do something with message
            ViewBag.TheMessage = "Thanks, we got your message.";

            return View();
        }

        public ActionResult Foo()
        {
            return View("About");
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "APSNETMVCSATM1";

            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }

            //return Content(serial);
            //return Json(new { name = "serial", value = serial }, 
            //    JsonRequestBehavior.AllowGet);

            return RedirectToAction("About");
        }

        public ActionResult Quinten()
        {
            return View("Quinten");
        }
    }
}