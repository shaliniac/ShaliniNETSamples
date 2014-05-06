using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace MVC4StudentsApplication.Controllers
{
    public class StudentsController : Controller
    {
        private StudentsDatabaseEntities db = new StudentsDatabaseEntities();

        //
        // GET: /Students/

        public ActionResult Index()
        {
            return View(db.StudentTables.ToList());
        }

        //
        // GET: /Students/Details/5

        public ActionResult Details(int id = 0)
        {
            StudentTable studenttable = db.StudentTables.Find(id);
            if (studenttable == null)
            {
                return HttpNotFound();
            }
            return View(studenttable);
        }

        //
        // GET: /Students/Create

        public ActionResult Create()
        {
            return View(new StudentTable {StudentName = "Anita",StudentAddress= "48 Hello", StudentEmail = "t@y.com",StudentPhone="0156678" });

        }

        //
        // POST: /Students/Create



        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(StudentTable studenttable)
        {
            if (ModelState.IsValid)
            {
                db.StudentTables.Add(studenttable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studenttable);
        }

        //
        // GET: /Students/Edit/5

        public ActionResult Edit(int id = 0)
        {
            StudentTable studenttable = db.StudentTables.Find(id);
            if (studenttable == null)
            {
                return HttpNotFound();
            }
            return View(studenttable);
        }

        //
        // POST: /Students/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StudentTable studenttable)
        {
            try
            {


                if (ModelState.IsValid)
                {
                    db.Entry(studenttable).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(studenttable);
            }
            catch(Exception e)
            {
                return null;
                
            }


        }

        //
        // GET: /Students/Delete/5

        public ActionResult Delete(int id = 0)
        {
            StudentTable studenttable = db.StudentTables.Find(id);
            if (studenttable == null)
            {
                return HttpNotFound();
            }
            return View(studenttable);
        }

        //
        // POST: /Students/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentTable studenttable = db.StudentTables.Find(id);
            db.StudentTables.Remove(studenttable);
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