using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Zadatak13
{
    public class DataProvider
    {
        private string _filePath;
        private string _errorMessage;

        private List<Album> _katalog = new List<Album>();

        public DataProvider(string filePath)
        {
            _filePath = filePath;
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
        }

        public bool LoadData()
        {
            _katalog = new List<Album>();

            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    string line;
                    line = sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] lineComponents = line.Split('|');
                            Album A = new Album();
                            A.Izvodjac = lineComponents[0];
                            A.Naziv = lineComponents[1];
                            A.Zanr = lineComponents[2];
                            A.GodinaIzdanja = Convert.ToInt32(lineComponents[3]);
                            A.IzdavackaKuca = lineComponents[4];
                            A.Slika = lineComponents[5];
                            _katalog.Add(A);
                        }
                        line = sr.ReadLine();
                    }
                    sr.Close();

                }
                return true;
            }
            catch (Exception ex)
            {
                _errorMessage = ex.Message;
            }
            return false;
        }

        public List<string> SviZanrovi()
        {
            List<string> lista = new List<string>();
            lista.Add("");

            foreach (Album a in _katalog)
            {
                if (!lista.Contains(a.Zanr))
                {
                    lista.Add(a.Zanr);
                }
            }

            return lista;
        }

        public Dictionary<int, string> SveGodine()
        {
            Dictionary<int, string> godine = new Dictionary<int, string>();
            godine.Add(0, "");
                    
            foreach (Album a in _katalog)
            {
                if (!godine.ContainsKey(a.GodinaIzdanja))
                {
                    godine.Add(a.GodinaIzdanja, a.GodinaIzdanja.ToString());
                }
            }

            return godine;
        }

        public List<Album> Trazi(string izvodjac = "", string naziv = "", string zanr = "", int godina = 0, string izdavackaKuca = "")
        {
            List<Album> rez = new List<Album>();
            foreach (Album a in _katalog)
            {
                if (
                    (string.IsNullOrEmpty(izvodjac) || a.Izvodjac.ToLower().Contains(izvodjac.ToLower())) &&
                    (string.IsNullOrEmpty(naziv) || a.Naziv.ToLower().Contains(naziv.ToLower())) &&
                    (string.IsNullOrEmpty(zanr) || a.Zanr.ToLower() == zanr.ToLower()) &&
                    (godina == 0 || a.GodinaIzdanja == godina) &&
                    (string.IsNullOrEmpty(izdavackaKuca) || a.IzdavackaKuca.ToLower().Contains(izdavackaKuca.ToLower()))
                   )

                {
                    rez.Add(a);
                }
            }

            return rez;
        }
    }

}