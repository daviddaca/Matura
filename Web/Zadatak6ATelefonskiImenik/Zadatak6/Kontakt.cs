using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vezba4
{
    public class Kontakt
    {
        public string ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string EMail { get; set; }
        public string Mesto { get; set; }

        public Kontakt(string linija)
        {
            string[] elementi = linija.Split('|');
            ID = elementi[0];
            Ime = elementi[1];
            Prezime = elementi[2];
            Adresa = elementi[3];
            Telefon = elementi[4];
            EMail = elementi[5];
            Mesto = elementi[6];
        }
    }
}