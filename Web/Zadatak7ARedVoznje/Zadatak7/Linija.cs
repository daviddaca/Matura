using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vezba5
{
    public class Linija
    {
        private string naziv;
        private List<Polazak> polasci;

        public List<Polazak> Polasci
        {
            get { return polasci; }
            set { polasci = value; }
        }
        private List<Smer> smerovi;

        public List<Smer> Smerovi
        {
            get { return smerovi; }
            set { smerovi = value; }
        }

        private string nazivFajla;

        public string NazivFajla
        {
            get { return nazivFajla; }
            set { nazivFajla = value; }
        }

        public Linija(string NazivFajla)
        {
            smerovi = new List<Smer>();
            polasci = new List<Polazak>();
            nazivFajla = NazivFajla;
            naziv = System.IO.Path.GetFileNameWithoutExtension(nazivFajla);
        }

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public List<Polazak> PronadjiPolaske(string Smer)
        {
            List<Polazak> rez = new List<Polazak>();

            foreach (Polazak p in polasci)
            {
                if (p.Smer == Smer)
                {
                    rez.Add(p);
                }
            }
            return rez;
        }

        public bool ProcitajPodatke()
        {

            System.IO.StreamReader SR = new System.IO.StreamReader(nazivFajla, System.Text.Encoding.UTF8);

            string red = SR.ReadLine();

            Smer TrenutniSmer = null;
            string TrenutniDan = "";

            while (!string.IsNullOrEmpty(red))
            {

                if (red.Contains("SMER:"))
                {
                    Smer Smer = new Smer();
                    Smer.NazivSmera = red.Replace("SMER:", "");
                    TrenutniSmer = Smer;
                    smerovi.Add(Smer);
                }
                else if (red.Contains("DAN:"))
                {
                    TrenutniDan = red.Replace("DAN:", "");
                }
                else
                {
                    Polazak Polazak = new Polazak();
                    Polazak.Linija = this.Naziv;
                    Polazak.Smer = TrenutniSmer.NazivSmera;
                    Polazak.Vreme = red;

                    polasci.Add(Polazak);
                }

                red = SR.ReadLine();
            }

            SR.Close();

            return true;
        }
    }
}