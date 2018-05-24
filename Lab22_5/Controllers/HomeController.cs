using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab22_5.Controllers
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

        public ActionResult Register(string name, string color, string userName)
        {                  
            Session["name"] = name;
            Session["color"] = color;
            Session["userName"] = userName;            

            return View();
        }

        public ActionResult Welcome()
        {
            return View();
        }
        // clears Session data 
        public ActionResult Logout()
        {
            Session.Clear();

            return View();
        }
    }
}

       