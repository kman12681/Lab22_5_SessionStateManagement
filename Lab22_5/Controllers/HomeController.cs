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

        public ActionResult Register(string name, string color, string city)
        {  
            //if form parameters null, add them to Session values

            if (Session["name"] == null)
            {
                Session.Add("name", name);
            }           
           
            if (Session["color"] == null)
            {
                Session.Add("color", color);
                
            }           

            if (Session["city"] == null)
            {
                Session.Add("city", city);
               
            }           

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

       