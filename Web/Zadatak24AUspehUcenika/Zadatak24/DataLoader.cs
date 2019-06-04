using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Zadatak24
{
    public class DataLoader
    {
        public string _ErrorMessage;

        List<Uspeh> _UspehPoRazredima = new List<Uspeh>();

        public DataLoader()
        {
            //
        }

        public string ErrorMessage
        {
            get { return _ErrorMessage; }
        }

        public List<Uspeh> UspehPoRazredima
        {
            get
            {
                return _UspehPoRazredima;
            }
        }

        public bool LoadData()
        {
            _UspehPoRazredima = new List<Uspeh>();

            try
            {
                using (SqlCommand cmd = SQLKonekcija.GetSqlCommand)
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Uspeh";                    

                    DataTable table = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    cmd.Connection.Open();

                    da.Fill(table);

                    foreach (DataRow row in  table.Rows)
                    {
                        Uspeh uspeh = new Uspeh();
                        uspeh.Razred = Convert.ToInt32(row["Razred"]);
                        uspeh.Nedovoljan = Convert.ToInt32(row["Nedovoljan"]);
                        uspeh.Dovoljan = Convert.ToInt32(row["Dovoljan"]);
                        uspeh.Dobar = Convert.ToInt32(row["Dobar"]);
                        uspeh.Vrlodobar = Convert.ToInt32(row["Vrlodobar"]);
                        uspeh.Odlican = Convert.ToInt32(row["Odlican"]);
                        uspeh.ProsecnaOcena = Convert.ToDouble(row["ProsecnaOcena"]);
                        _UspehPoRazredima.Add(uspeh);
                    }                    
                }

                return true;
            }
            catch (Exception ex)
            {
                _ErrorMessage = ex.GetBaseException().Message;                
            }

            return false;
        }
    }
}