using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zadatak10
{
    public class Kurs
    {
        public DateTime Datum { get; set; }
        public string OznakaValute { get; set; }
        public decimal VrednostKursa { get; set; }

        public Kurs()
        {
            //
        }
    }
}