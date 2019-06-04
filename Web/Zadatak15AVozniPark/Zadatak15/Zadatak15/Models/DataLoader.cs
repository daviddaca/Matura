using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Zadatak15.Models
{
    public class DataLoader
    {
        private string _dataFolderPath;
        private string _ErrorMessage;

        public DataLoader()
        {
            _dataFolderPath = @"C:\Users\Nikola\Desktop\Zadatak15\Zadatak15\Podaci\";
        }

        public string ErrorMessage
        {
            get { return _ErrorMessage; }
        }

        public List<Vozilo> LoadVozila()
        {
            List<Vozilo> Vozila = new List<Vozilo>();

            try
            {
                using (StreamReader sr = new StreamReader(Path.Combine(_dataFolderPath, "vozila.txt")))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] komponente = line.Split('|');
                            Vozilo V = new Vozilo();
                            V.RegistarskiBroj = komponente[0];
                            V.MarkaVozila = komponente[1];
                            V.GodinaProizvodnje = Convert.ToInt32(komponente[2]);
                            V.Boja = komponente[3];

                            V.Putovanja = this.LoadPutovanja(V.RegistarskiBroj);

                            Vozila.Add(V);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _ErrorMessage = ex.Message;
            }

            return Vozila;
        }

        public List<PredjeniPut> LoadPutovanja(string registarskiBroj)
        {
            List<PredjeniPut> Putovanja = new List<PredjeniPut>();

            try
            {
                if (System.IO.File.Exists(Path.Combine(_dataFolderPath, registarskiBroj + ".txt")))
                {
                    using (StreamReader sr = new StreamReader(Path.Combine(_dataFolderPath, registarskiBroj + ".txt")))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            if (!string.IsNullOrEmpty(line))
                            {
                                string[] komponente = line.Split('|');
                                PredjeniPut P = new PredjeniPut();
                                P.RegistarskiBroj = registarskiBroj;
                                P.Datum = komponente[0];
                                P.OdMesta = komponente[1];
                                P.DoMesta = komponente[2];
                                P.PredjenoKM = Convert.ToInt32(komponente[3]);
                                Putovanja.Add(P);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _ErrorMessage = ex.Message;
            }

            return Putovanja;
        }

        public bool DodajPredjeniPut(PredjeniPut put)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(_dataFolderPath, put.RegistarskiBroj + ".txt"), true))
                {
                    sw.WriteLine(put.Datum + '|' + put.OdMesta + '|' + put.DoMesta + "|" + put.PredjenoKM);
                }
                return true;

            }
            catch (Exception ex)
            {
                _ErrorMessage = ex.Message;
            }
            return false;
        }
    }
}