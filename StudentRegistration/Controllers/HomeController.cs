using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentRegistration.Models;
using StudentRegistration.Data;
using System.Net;
using System.Data.Entity;

namespace StudentRegistration.Controllers
{
    public class HomeController : Controller
    {

        private StudentContext db = new StudentContext();

        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        public ActionResult Edit(int? id)
        {
            Students student = db.Students.Find(id);
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,name,std,section")] Students student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,name,std,section")] Students student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        public ActionResult Delete(int? id)
        {

            Students student = db.Students.Find(id);
            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Students student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }





    }
}