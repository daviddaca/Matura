using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zadatak25
{
    public class Korisnik
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class BazaKorisnika
    {
        List<Korisnik> _Korisnici = new List<Korisnik>();

        public BazaKorisnika()
        {
            this.LoadData();
        }

        public List<Korisnik> Korisnici
        {
            get { return _Korisnici; }
        }

        private void LoadData()
        {
            Korisnik K = new Korisnik();
            K.Id = Guid.NewGuid().ToString();
            K.Username = "mika";
            K.Password = "123";
            _Korisnici.Add(K);

            K = new Korisnik();
            K.Id = Guid.NewGuid().ToString();
            K.Username = "zika";
            K.Password = "123";
            _Korisnici.Add(K);
        }

        public bool PrijavaKorisnika(HttpResponse response, string username, string password)
        {
            foreach (Korisnik k in _Korisnici)
            {
                if (k.Username.ToLower() == username.ToLower() && k.Password.ToLower() == password.ToLower())
                {
                    HttpCookie cookie = new HttpCookie("auth");
                    cookie.Expires = DateTime.Now.AddMinutes(60);
                    cookie.Value = k.Id;

                    response.Cookies.Add(cookie);

                    return true;
                }
            }
            return false;
        }

        public bool OdjavaKorisnika(HttpResponse response)
        {

            HttpCookie cookie = new HttpCookie("auth");
            cookie.Expires = DateTime.Now.AddMinutes(-1);            
            response.Cookies.Add(cookie);

            return true;
        }

        public bool KorisnikJePriavljen(HttpRequest request)
        {
            if (request != null && request.Cookies != null)
            {
                if (request.Cookies["auth"] != null)
                {
                    var value = request.Cookies["auth"].Value;
                    foreach (Korisnik k in _Korisnici)
                    {
                        if (k.Id == value)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public Korisnik PrijavljeniKorisnik(HttpRequest request)
        {
            if (request != null && request.Cookies != null)
            {
                if (request.Cookies["auth"] != null)
                {
                    var value = request.Cookies["auth"].Value;
                    foreach (Korisnik k in _Korisnici)
                    {
                        if (k.Id == value)
                        {
                            return k;
                        }
                    }
                }
            }

            return null;
        }


    }
}