using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadatak23.Models;

namespace Zadatak23.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ProveraKartice(string broj_kartice)
        {
            DataLoader dl = new DataLoader();
            LoyaltyCard card = dl.LoadCard(broj_kartice);            
            return PartialView("CardData", card);
        }

        public ActionResult About()
        {
            return View("About");
        }

    }
}