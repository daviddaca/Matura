using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Zadatak16.Models
{
    public class Raspored
    {
        private List<Cas> _casovi;
        private string _filePath;

        private string _errorMessage;

        public Raspored()
        {
            _casovi = new List<Cas>();
        }

        public Raspored(string filePath)
        {
            _casovi = new List<Cas>();
            _filePath = filePath;
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
        }

        public List<Cas> Casovi
        {
            get { return _casovi; }
        }

        public List<Cas> CasoviZaRbr(int rbr)
        {
            List<Cas> rez = new List<Cas>();

            string[] daniUNedelji = { "Ponedeljak", "Utorak", "Sreda", "Cetvrtak", "Petak" };

            foreach (var dan in daniUNedelji)
            {
                Cas cas = _casovi.FirstOrDefault(x => x.Rbr == rbr && 
                                                      x.DanUNedelji.ToLower() == dan.ToLower());
                if (cas == null) cas = new Cas() { Rbr = rbr, DanUNedelji = dan, Predmet = "/" };
                rez.Add(cas);
            }

            return rez;
        }

        public bool LoadData()
        {
            try
            {
                _casovi = new List<Cas>();

                if (System.IO.File.Exists(_filePath))
                {
                    DataSet dataset = new DataSet("Set");
                    dataset.ReadXml(_filePath);

                    foreach (DataRow dr in dataset.Tables[0].Rows)
                    {
                        Cas cas = new Cas();
                        cas.Rbr = Convert.ToInt32(dr["rbr"]);
                        cas.DanUNedelji = dr["DanUNedelji"].ToString();
                        cas.Predmet = dr["Predmet"].ToString();
                        _casovi.Add(cas);
                    }

                    //_casovi = _casovi.OrderBy(x => x.Rbr).ThenBy(x => x.DanUNedelji).ToList();

                    return true;
                }
                else
                {
                    _errorMessage = "Raspored časova nije definisan";
                }
            }
            catch (Exception ex)
            {
                _errorMessage = ex.Message;
            }
            return false;
        }
    }
}