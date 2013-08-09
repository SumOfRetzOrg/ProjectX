using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWeb.Data;

namespace MVCWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string testName = string.Empty;
            //var testrec = null;

            using (var db = new ProjectXEntities())
            {
                //var testrecords = from t in db.Tests
                //                  where t.TestName == "retz"
                //                  select t;

                //foreach (var test in testrecords)
                //{
                //    testName = test.TestName;
                //}


                var testrecs = db.Tests.Where(t => t.TestName == "retz").ToList();

                foreach (var tst in testrecs)
                {
                    testName = tst.TestName;
                }

                ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application. " + testName;
            }


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
