using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Zadatak10
{
    /// <summary>
    /// Summary description for KursnaLista
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class KursnaLista : System.Web.Services.WebService
    {
        //TODO: Popuniti file path
        private string FilePath = @"D:\VebProgramiranje\Zadatak10\Zadatak10\KursnaLista.txt";

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public decimal ProcitajKursNaDan(DateTime Datum, string valuta)
        {
            decimal kursNaDan = 0;
            DataProvider dp = new DataProvider(FilePath);
            if (dp.LoadData())
            {
                foreach (Kurs kurs in dp.KursnaLista)
                {
                    if (kurs.Datum == Datum && kurs.OznakaValute == valuta)
                    {
                        kursNaDan = kurs.VrednostKursa;
                    }
                }
            }

            return kursNaDan;
        }

        [WebMethod]
        public bool UpisiKursNaDan(DateTime datum, string valuta, decimal kurs)
        {
            DataProvider dp = new DataProvider(FilePath);
            Kurs K = new Kurs();
            K.Datum = datum;
            K.OznakaValute = valuta;
            K.VrednostKursa = kurs;
            return dp.UpisiKurs(K);
        }

        [WebMethod]
        public List<string> ProcitajSveValute()
        {
            List<string> ListaValuta = new List<string>();
            DataProvider dp = new DataProvider(FilePath);
            if (dp.LoadData())
            {
                foreach (Kurs K in dp.KursnaLista)
                {
                    if (!ListaValuta.Contains(K.OznakaValute))
                    {
                        ListaValuta.Add(K.OznakaValute);
                    }
                }            
            }
            return ListaValuta;
        }
    }
}
