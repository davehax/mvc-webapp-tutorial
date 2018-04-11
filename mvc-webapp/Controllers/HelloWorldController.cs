using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_webapp.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        public ActionResult Welcome(string message, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + message;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}