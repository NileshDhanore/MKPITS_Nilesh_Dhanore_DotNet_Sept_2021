using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        EmployeeContext em = new EmployeeContext();
        public ActionResult Index()
        {
            var db = em.Employees.ToList();
            return View(db);
        }
        public ActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee e)
        {
            em.Employees.Add(e);
            em.SaveChanges();
            ModelState.Clear();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int Id)
        {
            var db2=em.Employees.Find(Id);
            return View(db2);
        }
        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            em.Entry(e).State = EntityState.Modified;
            em.SaveChanges();
            ModelState.Clear();

            return RedirectToAction("Index");
        }
        public ActionResult Delete(int Id)
        {
            var db3 = em.Employees.Find(Id);
            return View(db3);
        }
        [HttpPost]
        public ActionResult Delete(Employee e)
        {
            em.Entry(e).State = EntityState.Deleted;
            em.SaveChanges();
            ModelState.Clear();

            return RedirectToAction("Index");
        }
        public ActionResult Details(int Id)
        {
            var db4 = em.Employees.Find(Id);
            return View(db4);
        }
    }
}