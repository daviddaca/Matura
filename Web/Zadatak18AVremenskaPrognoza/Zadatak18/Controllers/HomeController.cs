using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadatak18.Models;

namespace Zadatak18.Controllers
{
    public class HomeController : Controller
    {
        DataLoader DataLoader = new DataLoader();

        // GET: Home
        public ActionResult Index()
        {
            List<Prognoza> VremenskaPrognoza = DataLoader.LoadData();
            return View("MaxTemperature", VremenskaPrognoza);
        }

        public ActionResult Prognoza(string Sifra)
        {
            Prognoza Prognoza = new Prognoza();

            Prognoza.Mesta = new List<SelectListItem>();

            List<Prognoza> VremenskaPrognoza = DataLoader.LoadData();
            foreach (Prognoza P in VremenskaPrognoza)
            {
                Prognoza.Mesta.Add(new SelectListItem() { Text = P.NazivMesta, Value = P.Sifra });
            }

            if (!string.IsNullOrEmpty(Sifra))
            {
                Prognoza P = VremenskaPrognoza.FirstOrDefault(m => m.Sifra.ToLower() == Sifra.ToLower());
                if (P != null)
                {
                    Prognoza.Sifra = P.Sifra;
                    Prognoza.NazivMesta = P.NazivMesta;
                    Prognoza.MaxTemperatura = P.MaxTemperatura;
                    Prognoza.MinTemperatura = P.MinTemperatura;
                    Prognoza.Vreme = P.Vreme;
                }
            }

            return View("Prognoza", Prognoza);
        }
    }
}