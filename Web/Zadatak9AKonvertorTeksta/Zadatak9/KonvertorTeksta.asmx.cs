using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Zadatak9
{
    /// <summary>
    /// Summary description for KonvertorTeksta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class KonvertorTeksta : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string CirilicaULatinicu(string tekst)
        {           
            Konvertor Konvertor = new Konvertor();
            return Konvertor.CyrToLat(tekst);
        }

        [WebMethod]
        public string LatinicaUCirilicu(string tekst)
        {
            Konvertor Konvertor = new Konvertor();
            return Konvertor.LatToCyr(tekst);
        }
    }
}
