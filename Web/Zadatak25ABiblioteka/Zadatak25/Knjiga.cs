using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zadatak25
{
    public class Knjiga
    {
        public string ISBN { get; set; }
        public string Naslov { get; set; }
        public int Stanje { get; set; }
        public int Citano { get; set; }

        public Knjiga()
        {
            //
        }
    }
}