using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zadatak14
{
    public class Emisija
    {
        public string Vreme { get; set; }
        public string Naziv { get; set; }
        public string TipEmisije { get; set; }
        public string SlikaTipa { get; set; }

        public Emisija()
        {
            //
        }

        public Emisija (string txtred)
        {
            if (!string.IsNullOrEmpty(txtred))
            {
                string[] komponente = txtred.Split('|');

                if (komponente.Length > 0) Vreme = komponente[0];
                if (komponente.Length > 1) Naziv = komponente[1];
                if (komponente.Length > 2) TipEmisije = komponente[2];
                if (komponente.Length > 3) SlikaTipa = komponente[3];
            }
        }

    }
}