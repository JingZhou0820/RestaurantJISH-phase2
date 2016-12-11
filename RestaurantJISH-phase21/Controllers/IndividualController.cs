using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RestaurantJISH_phase21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantJISH_phase21.Models;
namespace RestaurantJISH_phase21.Controllers
{
    public class IndividualController : Controller
    {
        // GET: Individual
       [Authorize]
        public ActionResult checkout()
        {
            
            var userID = User.Identity.GetUserId();

            ViewBag.userId = userID;
            return View();
        }
    }
}