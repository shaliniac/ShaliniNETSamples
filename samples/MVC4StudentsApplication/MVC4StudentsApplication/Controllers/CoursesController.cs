using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4StudentsApplication.Controllers
{
    public class CoursesController : Controller
    {
        private StudentsDatabaseEntities db = new StudentsDatabaseEntities();

        //
        // GET: /Courses/

        public ActionResult Index()
        {
            return View(db.CourseTables.ToList());
        }

        //
        // GET: /Courses/Details/5

        public ActionResult Details(int id = 0)
        {
            CourseTable coursetable = db.CourseTables.Find(id);
            if (coursetable == null)
            {
                return HttpNotFound();
            }
            return View(coursetable);
        }

        //
        // GET: /Courses/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Courses/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseTable coursetable)
        {
            if (ModelState.IsValid)
            {
                db.CourseTables.Add(coursetable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(coursetable);
        }

        //
        // GET: /Courses/Edit/5

        public ActionResult Edit(int id = 0)
        {
            CourseTable coursetable = db.CourseTables.Find(id);
            if (coursetable == null)
            {
                return HttpNotFound();
            }
            return View(coursetable);
        }

        //
        // POST: /Courses/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CourseTable coursetable)
        {
            
            try
            {


                if (ModelState.IsValid)
                {
                    db.Entry(coursetable).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(coursetable);
            }
            catch (Exception e)
            {
                return null;

            }

        }

        //
        // GET: /Courses/Delete/5

        public ActionResult Delete(int id = 0)
        {
            CourseTable coursetable = db.CourseTables.Find(id);
            if (coursetable == null)
            {
                return HttpNotFound();
            }
            return View(coursetable);
        }

        //
        // POST: /Courses/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseTable coursetable = db.CourseTables.Find(id);
            db.CourseTables.Remove(coursetable);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}