using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zadatak12
{
    public class Utisak
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Email { get; set; }
        public string Komentar { get; set; }
        public DateTime Datum { get; set; }

        public Utisak()
        {
            Datum = DateTime.Now;
        }
    }
}