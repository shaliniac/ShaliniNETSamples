using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RichieCreativeUniversity.DAL;
using RichieCreativeUniversity.ViewModel;

namespace RichieCreativeUniversity.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext db = new SchoolContext();
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            var data = from student in db.Students
                       group student by student.EnrollmentDate into dateGroup
                       select new EnrollmentDateGroup()
                       {
                           EnrollmentDate = dateGroup.Key,
                           StudentCount = dateGroup.Count()
                       };
            return View(data);

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
