using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vezba4
{
    public class Imenik
    {
        private List<Kontakt> kontakti = new List<Kontakt>();
        private List<string> mesta = new List<string>();
        private string filePath;

        public Imenik()
        {
            filePath = @"D:\GoogleDrive\SKOLA\Web Programiranje\III Razred\Vezbe\ASP\Vezba4\Imenik.txt";
            this.UcitajKontakte();
        }

        public List<string> Mesta
        {
            get { return mesta; }
        }

        public List<Kontakt> Pronadji(ParametriZaTrazenje parametri)
        {
            List<Kontakt> RezultatPretrage = new List<Kontakt>();

            foreach (Kontakt K in kontakti)
            {
                if ((parametri.Ime == "" || K.Ime.ToLower().Contains(parametri.Ime.ToLower())) &&
                    (parametri.Prezime == "" || K.Prezime.ToLower().Contains(parametri.Prezime.ToLower())) &&
                    (parametri.Mesto == "" || K.Mesto.ToLower().Equals(parametri.Mesto.ToLower())) &&
                    (parametri.Telefon == "" || K.Telefon.ToLower().Equals(parametri.Telefon.ToLower())))
                {
                    RezultatPretrage.Add(K);
                }
            }

            return RezultatPretrage;
        }

        private void UcitajKontakte()
        {
            kontakti = new List<Kontakt>();
            mesta.Add(string.Empty);
            System.IO.StreamReader SR = new System.IO.StreamReader(filePath, System.Text.Encoding.UTF8);

            string linija = SR.ReadLine();

            while (!string.IsNullOrEmpty(linija))
            {
                Kontakt K = new Kontakt(linija);
                kontakti.Add(K);

                if (!mesta.Contains(K.Mesto))
                    mesta.Add(K.Mesto);

                linija = SR.ReadLine();
            }

            SR.Close();
        }
    }
}