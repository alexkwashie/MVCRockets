using MVCRockets.Filter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVCRockets.Controllers
{
    //[Authorize (Roles ="Admin", Users = "Mike")] //Only allow Admin and Mike
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

        //[Authorize] // Use the Authorize tag :s so when someone clicks on the Contact button, it will got to the sign up page till they are AUthorize and do otherwise 
        [MyLoggingFilter]
        public ActionResult Contact()
        {
            ViewBag.Message = "What do ou think?";

            return View();
        }

        
        [HttpPost]
        public ActionResult Contact(string message)
        {
            //TODO: Save input and act on it(eg. send to database etc)
            ViewBag.Message = "Thank you for the reply";
            return PartialView("_ThanksForFeedBack");
            //Create a partial view in the shared folder name it "_ThanksForFeedBack"
        }




        public ActionResult Backstage(string secret, string format)
        {
            if(secret != "special")
            {
                return new HttpStatusCodeResult(403);
            }


            //Sending parts of a webpage
            if (format == "text")
            {
                return Content("Current date in the UK is " + DateTime.Now.ToShortDateString());
            }
            else if (format== "json")
            {
                return Json(new { password = "Modblom", expires = DateTime.Now.ToString("22/07/2019")}, JsonRequestBehavior.AllowGet);
            }
            else if (format == "clean")
            {
                return PartialView();
            }

            //rightclick to add view
            return View();
        }

       
    }
}