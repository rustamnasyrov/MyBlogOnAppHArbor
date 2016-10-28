using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // comment
            return View();
        }

        // GET: Home
        public ActionResult About()
        {
            return View("About");
        }
    }

   
}