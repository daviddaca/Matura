using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace Zadatak25
{
    public class DataProvider
    {
        private string _xmlFilePath;
        private string _errorMessage;

        public List<Knjiga> _Knjige = new List<Knjiga>();

        public DataProvider(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
        }

        public List<Knjiga> Knjige
        {
            get { return _Knjige; }
        }


        public void Sortiraj()
        {
            _Knjige = _Knjige.OrderByDescending(x => x.Citano).ToList();
        }

        public bool LoadData()
        {
            try
            {
                _Knjige = new List<Knjiga>();

                XmlDocument xd = new XmlDocument();
                xd.Load(_xmlFilePath);

                XmlNodeList nodeList = xd.SelectNodes("biblioteka/knjiga");

                foreach(XmlNode node in nodeList)
                {
                    Knjiga Knjiga = new Knjiga();
                    Knjiga.ISBN = node.Attributes.GetNamedItem("ISBN").Value;
                    Knjiga.Naslov = node.Attributes.GetNamedItem("naslov").Value;
                    Knjiga.Stanje = Convert.ToInt32(node.Attributes.GetNamedItem("stanje").Value);
                    Knjiga.Citano = Convert.ToInt32(node.Attributes.GetNamedItem("citano").Value);
                    _Knjige.Add(Knjiga);
                }

                return true;
            }
            catch (Exception ex)
            {
                _errorMessage = ex.Message;
            }
            return false;    
        }
    }
}