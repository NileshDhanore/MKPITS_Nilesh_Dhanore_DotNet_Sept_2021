using Code_first_Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_first_Entity.Controllers
{
    public class HomeController : Controller
    {
        EmployeeContext em = new EmployeeContext();

        public ActionResult Index()
        {
            var db = em.Employees.ToList();
            return View(db);
        }
    }
}