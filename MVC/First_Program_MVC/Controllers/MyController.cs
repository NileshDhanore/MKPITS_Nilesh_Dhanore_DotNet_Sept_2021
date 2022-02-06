using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_Program_MVC.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index()
        {
            ViewData["Name"] = "Nilesh Dhanoe";
            ViewBag.role = "Assistant Professor";

            return View();
        }
    }
}