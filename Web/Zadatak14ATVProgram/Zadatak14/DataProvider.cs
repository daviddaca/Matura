using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zadatak14
{
    public class DataProvider
    {
        private string _folder_path;

        private string _error_message;

        public DataProvider(string folder_path)
        {
            _folder_path = folder_path;
        }

        public List<string> DateList()
        {
            List<string> dateList = new List<string>();
            string[] files = System.IO.Directory.GetFiles(_folder_path);
            dateList.Add("");
            foreach (string file in files)
            {
                dateList.Add(System.IO.Path.GetFileNameWithoutExtension(file));
            }
            return dateList;
        }

        public List<string> TipoviEmisija()
        {
            List<string> tipoviEmisija = new List<string>();
            tipoviEmisija.Add("");
            tipoviEmisija.Add("Film");
            tipoviEmisija.Add("Serija");
            tipoviEmisija.Add("Informativni program");
            tipoviEmisija.Add("Crtani film");            
            return tipoviEmisija;
        }

        public List<Emisija> LoadData(string datum = "", string tip_emisije = "")
        {
            List<Emisija> Emisije = new List<Emisija>();

            if (!string.IsNullOrEmpty(datum))
            {
                string file_path = System.IO.Path.Combine(_folder_path, datum + ".txt");
                Emisije = LoadDataFromFile(file_path);
            }
            else
            {
                string[] files = System.IO.Directory.GetFiles(_folder_path);
                foreach (string file in files)
                {
                    Emisije.AddRange(LoadDataFromFile(file));
                }
            }

            if (!string.IsNullOrEmpty(tip_emisije))
            {
                List<Emisija> FilteredList = new List<Emisija>();
                foreach (Emisija E in Emisije)
                {
                    if (E.TipEmisije.ToLower() == tip_emisije.ToLower())
                    {
                        FilteredList.Add(E);
                    }
                }
                return FilteredList;
            }

            return Emisije;

        }

        public List<Emisija> LoadDataFromFile(string file_path)
        {
            List<Emisija> Emisije = new List<Emisija>();

            try
            {
                if (System.IO.File.Exists(file_path))
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(file_path);

                    string line = sr.ReadLine();

                    while (!string.IsNullOrEmpty(line))
                    {
                        Emisija E = new Emisija(line);
                        Emisije.Add(E);
                        line = sr.ReadLine();
                    }

                    sr.Close();
                }

            }
            catch (Exception e)
            {
                _error_message = e.Message;
            }

            return Emisije;
        }

    }
}