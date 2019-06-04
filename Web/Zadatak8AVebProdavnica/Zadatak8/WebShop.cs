using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vezba7
{
    public class WebShop
    {
        private List<Telefon> Telefoni = new List<Telefon>();

        public WebShop()
        {
            this.UcitajProizvode();
        }

        private void UcitajProizvode()
        {
            Telefoni = new List<Telefon>();
            System.IO.StreamReader SR = new System.IO.StreamReader(@"D:\VebProgramiranje\Zadatak8\Zadatak8\Prodavnica.txt", System.Text.Encoding.UTF8);

            string linija = SR.ReadLine();

            while (!string.IsNullOrEmpty(linija))
            {
                Telefoni.Add(new Telefon(linija));
                linija = SR.ReadLine();
            }

            SR.Close();
        }

      
        public List<Telefon> Pronadji(ParametriZaTrazenje parametri)
        {
            List<Telefon> RezultatPretrage = new List<Telefon>();

            foreach (Telefon K in Telefoni)
            {
                if ((parametri.Proizvodjac == "" || K.Prizvodjac.ToLower().Equals(parametri.Proizvodjac.ToLower())) &&
                    (parametri.RAM == "" || K.Ram.ToLower().Equals(parametri.RAM.ToLower())) &&
                    (parametri.DualSIM == "" || K.DualSIM.ToLower().Equals(parametri.DualSIM.ToLower())) &&
                    (parametri.Procesor == "" || K.Procesor.ToLower().Equals(parametri.Procesor.ToLower())) &&
                    (parametri.EkranOd == 0 || K.Ekran >= parametri.EkranOd) &&
                    (parametri.EkranDo == 0 || K.Ekran <= parametri.EkranDo) &&
                    (parametri.Kamera == "" || K.Kamera.ToLower().Equals(parametri.Kamera.ToLower())))
                {
                    RezultatPretrage.Add(K);
                }
            }

            return RezultatPretrage;
        }
      
    }
}