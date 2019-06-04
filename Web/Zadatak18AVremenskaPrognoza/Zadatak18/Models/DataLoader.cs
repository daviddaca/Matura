using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;

namespace Zadatak18.Models
{
    public class DataLoader
    {
        private string _filePath;
        private string _ErrorMessage;

        public DataLoader()
        {
            _filePath = ConfigurationManager.AppSettings.Get("FilePath");  
        }

        public string ErrorMessage
        {
            get { return _ErrorMessage; }
        }

        public List<Prognoza> LoadData()
        {
            List<Prognoza> VremenskaPrognoza = new List<Prognoza>();

            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(_filePath);

                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        Prognoza P = new Prognoza();
                        P.Sifra = row["Mesto"].ToString();
                        P.NazivMesta = row["NazivMesta"].ToString();
                        P.MinTemperatura = Convert.ToInt32(row["MinTemperatura"]);
                        P.MaxTemperatura = Convert.ToInt32(row["MaxTemperatura"]);
                        P.Vreme = row["Vreme"].ToString();

                        VremenskaPrognoza.Add(P);
                    }
                }
            }
            catch (Exception ex)
            {
                _ErrorMessage = ex.Message;
            }

            return VremenskaPrognoza;
        }

    }
}