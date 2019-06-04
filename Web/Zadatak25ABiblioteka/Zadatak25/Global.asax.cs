using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Zadatak25
{
    public class Global : System.Web.HttpApplication
    {
        public static BazaKorisnika BazaKorisnika;

        protected void Application_Start(object sender, EventArgs e)
        {
            BazaKorisnika = new BazaKorisnika();
        }
    }
}