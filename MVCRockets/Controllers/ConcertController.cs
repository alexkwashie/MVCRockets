using MVCRockets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRockets.Controllers
{
    public class ConcertController : Controller
    {

        //Create an instance from the concert class and add data to the properties
        Concert concert = new Concert {
            Name = "Tata Concert",
            City = "Mumbai",
            ConcertDate = DateTime.UtcNow,
            Price = 100.99,
            tickets = 200
        };

        //Create or add Editing feature 
        public ActionResult Edit()
        {
            return View(concert);
            //right-click on the View() -> Add view -> give it a name and select Edit (Concert (MVCRockets.Models))
        }

        // GET: Concert
        public ActionResult Index()
        {
            return View(concert);
            //right-click on the View() -> Add view -> give it a name and select detail -> Concert (MVCRockets.Models))
        }
    }
     
}