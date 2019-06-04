using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Globalization;

namespace Zadatak10
{
    public class DataProvider
    {
        private string _filePath;
        private string _errorMessage;
        private List<Kurs> _kursnaLista;

        public DataProvider(string filePath)
        {
            _filePath = filePath;
            _kursnaLista = new List<Kurs>();
        }

        public List<Kurs> KursnaLista
        {
            get { return _kursnaLista; }
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
        }

        public bool LoadData()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    string line = "";
                    while (!string.IsNullOrEmpty((line = sr.ReadLine())))
                    {
                        Kurs K = new Kurs();
                        var lineComponents = line.Split('|');
                        if (lineComponents.Length > 0) K.Datum = DateTime.ParseExact(lineComponents[0], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                        if (lineComponents.Length > 1) K.OznakaValute = lineComponents[1];
                        if (lineComponents.Length > 2) K.VrednostKursa = Decimal.Parse(lineComponents[2], CultureInfo.InvariantCulture);
                        _kursnaLista.Add(K);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                _errorMessage = ex.Message;
                return false;
            }
        }

        public bool UpisiKurs(Kurs kurs)
        {
            try
            {
                if (this.LoadData())
                {
                    //bool Exists = _kursnaLista.Exists(x => x.Datum == kurs.Datum && x.OznakaValute == kurs.OznakaValute);

                    bool Exists = false;
                    foreach (Kurs k in _kursnaLista)
                    {
                        if (k.Datum == kurs.Datum && k.OznakaValute == kurs.OznakaValute)
                        {
                            Exists = true;  
                        }
                    }

                    if (!Exists)
                    {
                        using (StreamWriter sw = new StreamWriter(_filePath, true))
                        {
                            sw.WriteLine(string.Format("{0}|{1}|{2}",
                                                        kurs.Datum.ToString("dd.MM.yyyy"),
                                                        kurs.OznakaValute,
                                                        kurs.VrednostKursa.ToString("#0.00")));
                        }
                    }

                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                _errorMessage = ex.Message;
                return false;
            }
        }
    }
}