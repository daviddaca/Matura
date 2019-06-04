using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadatak16.Models;

namespace Zadatak16.Controllers
{
    public class HomeController : Controller
    {
        private string filepath = @"C:\Users\Nikola\Desktop\Zadatak16\Zadatak16\Podaci\raspored.xml";

        // GET: Home
        public ActionResult Index()
        {           
            Raspored raspored = new Raspored(filepath);
            raspored.LoadData();

            return View("Index", raspored);
        }

        public ActionResult UcitajRaspored()
        {
            return View("Ucitaj");
        }

        [HttpPost]
        public ActionResult FileUpload()
        {

            if (Request.Files.Count > 0)
            {
                try
                {
                    Request.Files[0].SaveAs(filepath);
                }
                catch { }
            }

            return RedirectToAction("Index");
        }
    }
}