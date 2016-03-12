using inForce.Models;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace inForce.Controllers
{
    [RequireHttps]
    [HandleError]
    public class HomeController : Controller
    {
        
        public ActionResult HomeView()
        {
            return View();
        }


        public ActionResult Index(int? id)
        {
            
            return RedirectToAction("HomeView");
        }
        

       public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}