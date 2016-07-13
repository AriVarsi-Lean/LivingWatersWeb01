using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Living_Waters.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

           // return View("About", "~/Views/Shared/View");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            //return View("Contact", "~/Views/Shared/View");
            return View();
        }
        public ActionResult Downloads()
        {
            ViewBag.Message = "Downloads";

            //return View("Contact", "~/Views/Shared/View");
            return View();
        }
        public ActionResult Vacancies()
        {
            ViewBag.Message = "Your contact page.";

            //return View("Contact", "~/Views/Shared/View");
            return View();
        }
        public ActionResult News()
        {
            ViewBag.Message = "Your contact page.";

            //return View("Contact", "~/Views/Shared/View");
            return View();
        }
        public ActionResult Events()
        {
            ViewBag.Message = "Your contact page.";

            //return View("Contact", "~/Views/Shared/View");
            return View();
        }
        public ActionResult Admissions()
        {
            ViewBag.Message = "Your contact page.";

            //return View("Contact", "~/Views/Shared/View");
            return View();
        }
        public ActionResult Gallery()
        {
            ViewBag.Message = "Your contact page.";

            //return View("Contact", "~/Views/Shared/View");
            return View();
        }
        public ActionResult Library()
        {
            ViewBag.Message = "Your contact page.";

            //return View("Contact", "~/Views/Shared/View");
            return View();
        }

        public ActionResult Centres()
        {
            ViewBag.Message = "Your contact page.";

            //return View("Contact", "~/Views/Shared/View");
            return View();
        }
        public ActionResult Administration()
        {
            ViewBag.Message = "Your contact page.";

            //return View("Contact", "~/Views/Shared/View");
            return View();
        }
    }
}