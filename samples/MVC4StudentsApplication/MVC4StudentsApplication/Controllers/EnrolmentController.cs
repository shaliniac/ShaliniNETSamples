using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4StudentsApplication.Controllers
{
    public class EnrolmentController : Controller
    {
        private StudentsDatabaseEntities db = new StudentsDatabaseEntities();

        //
        // GET: /Enrolment/

        public ActionResult Index()
        {
            var enrolmenttables = db.EnrolmentTables.Include(e => e.CourseTable).Include(e => e.StudentTable);
            return View(enrolmenttables.ToList());
        }

        //
        // GET: /Enrolment/Details/5

        public ActionResult Details(int id = 0)
        {
            EnrolmentTable enrolmenttable = db.EnrolmentTables.Find(id);
            if (enrolmenttable == null)
            {
                return HttpNotFound();
            }
            return View(enrolmenttable);
        }

        //
        // GET: /Enrolment/Create

        public ActionResult Create()
        {
            ViewBag.CourseID = new SelectList(db.CourseTables, "CourseID", "CourseTitle");
            ViewBag.StudentID = new SelectList(db.StudentTables, "StudentID", "StudentName");
            return View();
        }

        //
        // POST: /Enrolment/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EnrolmentTable enrolmenttable)
        {
            if (ModelState.IsValid)
            {
                db.EnrolmentTables.Add(enrolmenttable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseID = new SelectList(db.CourseTables, "CourseID", "CourseTitle", enrolmenttable.CourseID);
            ViewBag.StudentID = new SelectList(db.StudentTables, "StudentID", "StudentName", enrolmenttable.StudentID);
            return View(enrolmenttable);
        }

        //
        // GET: /Enrolment/Edit/5

        public ActionResult Edit(int id = 0)
        {
            EnrolmentTable enrolmenttable = db.EnrolmentTables.Find(id);
            if (enrolmenttable == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseID = new SelectList(db.CourseTables, "CourseID", "CourseTitle", enrolmenttable.CourseID);
            ViewBag.StudentID = new SelectList(db.StudentTables, "StudentID", "StudentName", enrolmenttable.StudentID);
            return View(enrolmenttable);
        }

        //
        // POST: /Enrolment/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EnrolmentTable enrolmenttable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enrolmenttable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseID = new SelectList(db.CourseTables, "CourseID", "CourseTitle", enrolmenttable.CourseID);
            ViewBag.StudentID = new SelectList(db.StudentTables, "StudentID", "StudentName", enrolmenttable.StudentID);
            return View(enrolmenttable);
        }

        //
        // GET: /Enrolment/Delete/5

        public ActionResult Delete(int id = 0)
        {
            EnrolmentTable enrolmenttable = db.EnrolmentTables.Find(id);
            if (enrolmenttable == null)
            {
                return HttpNotFound();
            }
            return View(enrolmenttable);
        }

        //
        // POST: /Enrolment/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EnrolmentTable enrolmenttable = db.EnrolmentTables.Find(id);
            db.EnrolmentTables.Remove(enrolmenttable);
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