using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Recnik
{
    public class Rec
    {
        public long Id { get; set; }
        public string Srpski { get; set; }
        public string Engleski { get; set; }
        public string Opis { get; set; }

        public Rec()
        {
            //
        }

        public Rec(DataRow dr)
        {
            Id = (long)dr["Id"];
            Srpski = dr["Srpski"].ToString();
            Engleski = dr["Engleski"].ToString();
            Opis = dr["Opis"].ToString();
        }
    }
}