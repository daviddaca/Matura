using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Zadatak12
{
    public class DataProvider
    {
        private string _ErrorMessage;

        public DataProvider()
        {
            //
        }

        public string ErrorMessage
        {
            get { return _ErrorMessage; }
        }

        public bool Snimi(Utisak utisak)
        {
            try
            {
                using (SqlCommand cmd = SQLKonekcija.GetCommand)
                {
                    using (cmd.Connection)
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO Utisak (Ime, Email, Komentar, Datum) " +
                                          "VALUES (@ime, @email, @komentar, @datum) ";

                        cmd.Parameters.AddWithValue("@ime", utisak.Ime);
                        cmd.Parameters.AddWithValue("@email", utisak.Email);
                        cmd.Parameters.AddWithValue("@komentar", utisak.Komentar);
                        cmd.Parameters.AddWithValue("@datum", utisak.Datum);

                        cmd.Connection.Open();

                        cmd.ExecuteNonQuery();
                       
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                _ErrorMessage = ex.Message;
                return false;
            }
        }
    }
}