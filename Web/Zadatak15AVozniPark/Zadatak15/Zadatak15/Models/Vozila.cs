using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zadatak15.Models
{
    public class Vozila
    {
        public List<Vozilo> ListaVozila { get; set; }
        public string RegistarskiBroj { get; set; }

        public Vozila()
        {
            ListaVozila = new List<Models.Vozilo>();
        }
    }
}