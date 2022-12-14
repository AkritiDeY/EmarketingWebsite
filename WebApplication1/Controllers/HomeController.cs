using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is an OLX-clone named E-market HUB created by developer Akriti Dey.";
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This is how you can reach us ->";

            return View();
        }
    }
}