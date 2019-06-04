using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zadatak18.Models
{
    public class Prognoza
    {
        public string Sifra { get; set; }
        public string NazivMesta { get; set; }
        public int MinTemperatura { get; set; }
        public int MaxTemperatura { get; set; }
        public string Vreme { get; set; }

        public List<SelectListItem> Mesta;
    }
}