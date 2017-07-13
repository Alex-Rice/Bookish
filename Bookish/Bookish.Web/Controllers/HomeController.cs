using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookish.Web.Controllers
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

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UserHomepage()
        {
            ViewBag.Message = "Your user homepage.";

            return View();
        }

        public ActionResult LibraryCatalog()
        {
            ViewBag.Message = "Library catalog.";

            return View();
        }

        public ActionResult NewBookForm()
        {
            ViewBag.Message = "New book form.";
            return View();
        }

        public ActionResult NewBookConfirmation()
        {
            ViewBag.Message = "New book confirmation.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Login page.";

            return View();
        }
    }
}