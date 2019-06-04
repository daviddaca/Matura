using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zadatak15.Models
{
    public class Vozilo
    {
        public string RegistarskiBroj { get; set; }
        public string MarkaVozila { get; set; }
        public int GodinaProizvodnje { get; set; }
        public string Boja { get; set; }

        public List<PredjeniPut> Putovanja;

        public int UkupanPredjeniPut
        {
            get
            {
                int ukupno = 0;

                foreach (PredjeniPut p in Putovanja)
                {
                    ukupno = ukupno + p.PredjenoKM;
                }

                return ukupno;
            }
        }

    }
}