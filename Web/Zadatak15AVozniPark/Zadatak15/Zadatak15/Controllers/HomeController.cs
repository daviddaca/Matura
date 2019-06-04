using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadatak15.Models;

namespace Zadatak15.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index(string RegistarskiBroj)
        {
            DataLoader dl = new DataLoader();

            Vozila Vozila = new Vozila();
            Vozila.ListaVozila = dl.LoadVozila();

            if (!string.IsNullOrEmpty(RegistarskiBroj))
            {
                Vozila.RegistarskiBroj = RegistarskiBroj;
                Vozila.ListaVozila = Vozila.ListaVozila.FindAll(v => v.RegistarskiBroj.ToLower().Contains(RegistarskiBroj.ToLower()));
            }

            return View("List", Vozila);
        }

        public ActionResult Unos()
        {
            PredjeniPut pput = new PredjeniPut();

            DataLoader dl = new DataLoader();

            foreach (var v in dl.LoadVozila())
            {
                pput.SvaVozila.Add(new SelectListItem() { Value = v.RegistarskiBroj, Text = v.RegistarskiBroj });
            }

            return View("Edit", pput);
        }

        [HttpPost]
        public ActionResult Snimi(PredjeniPut pput)
        {
            DataLoader dl = new DataLoader();

            foreach (var v in dl.LoadVozila())
            {
                pput.SvaVozila.Add(new SelectListItem() { Value = v.RegistarskiBroj, Text = v.RegistarskiBroj });
            }

            if (ModelState.IsValid)
            {
                if (dl.DodajPredjeniPut(pput))
                {
                    Vozila Vozila = new Vozila();
                    Vozila.ListaVozila = dl.LoadVozila();
                    return View("List", Vozila);
                }
            }

            return View("Edit", pput);

        }
    }
}