using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vezba7
{
    public class Telefon
    {
        public string ID { get; set; }
        public string Naziv { get; set; }
        public string Prizvodjac { get; set; }
        public string Ram { get; set; }
        public string DualSIM { get; set; }
        public double Ekran { get; set; }
        public string Kamera { get; set; }
        public string Procesor { get; set; }
        public string Slika { get; set; }
        public string Cena { get; set; }

        public Telefon(string linija)
        {
            string[] elementi = linija.Split('|');
            ID = elementi[0];
            Naziv = elementi[1];
            Prizvodjac = elementi[2];
            Ram = elementi[3];
            DualSIM = elementi[4];
            Ekran = Double.Parse(elementi[5]);
            Kamera = elementi[6];
            Procesor = elementi[7];
            Slika = elementi[8];
            Cena = elementi[9];
        }
    }
}