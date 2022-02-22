using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;  // only this is enable 

namespace First_Create_Controller.Controllers
{
    public class HomeController : Controller // here the Homecontroller is child class of controller which is sytem.web.mvc file
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}