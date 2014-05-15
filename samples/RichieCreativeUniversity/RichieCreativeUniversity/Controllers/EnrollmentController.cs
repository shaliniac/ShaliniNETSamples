using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RichieCreativeUniversity.Models;
using RichieCreativeUniversity.DAL;

namespace RichieCreativeUniversity.Controllers
{
    public class EnrollmentController : Controller
    {
        private SchoolContext db = new SchoolContext();

        //
        // GET: /Enrollment/

        public ActionResult Index()
        {
            var enrollments = db.Enrollments.Include(e => e.Course).Include(e => e.Student);
            return View(enrollments.ToList());
        }

        //
        // GET: /Enrollment/Details/5

        public ActionResult Details(int id = 0)
        {
            Enrollment enrollment = db.Enrollments.Find(id);
            if (enrollment == null)
            {
                return HttpNotFound();
            }
            return View(enrollment);
        }

        //
        // GET: /Enrollment/Create

        public ActionResult Create()
        {
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "Title");
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "LastName");
            return View();
        }

        //
        // POST: /Enrollment/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Enrollment enrollment)
        {
            if (ModelState.IsValid)
            {
                db.Enrollments.Add(enrollment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "Title", enrollment.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "LastName", enrollment.StudentID);
            return View(enrollment);
        }

        //
        // GET: /Enrollment/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Enrollment enrollment = db.Enrollments.Find(id);
            if (enrollment == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "Title", enrollment.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "LastName", enrollment.StudentID);
            return View(enrollment);
        }

        //
        // POST: /Enrollment/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Enrollment enrollment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enrollment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "Title", enrollment.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "LastName", enrollment.StudentID);
            return View(enrollment);
        }

        //
        // GET: /Enrollment/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Enrollment enrollment = db.Enrollments.Find(id);
            if (enrollment == null)
            {
                return HttpNotFound();
            }
            return View(enrollment);
        }

        //
        // POST: /Enrollment/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Enrollment enrollment = db.Enrollments.Find(id);
            db.Enrollments.Remove(enrollment);
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