using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Recnik
{
    public class DataLoader
    {

        private string errMessage;

        public DataLoader()
        {
            //
        }

        public string ErrorMessage
        {
            get
            {
                return errMessage;
            }
        }

        public List<Rec> SrpskiNaEngleski(string srpskaRec)
        {
            List<Rec> EngleskeReci = new List<Rec>();
            errMessage = "";

            try
            {
                using (SqlCommand command = SQLKonekcija.GetCommand)
                {
                    using (command.Connection)
                    {
                        command.CommandType = CommandType.Text;
                        command.CommandText = string.Format("SELECT * FROM Reci WHERE Srpski = '{0}'", srpskaRec);

                        command.Connection.Open();

                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();

                            da.Fill(dt);

                            foreach (DataRow dr in dt.Rows)
                            {
                                Rec R = new Rec(dr);
                                EngleskeReci.Add(R);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
            }

            return EngleskeReci;
        }

        public List<Rec> EngleskiNaSrpski(string engleskaRec)
        {
            List<Rec> SrpskeReci = new List<Rec>();
            errMessage = "";

            try
            {
                using (SqlCommand command = SQLKonekcija.GetCommand)
                {
                    using (command.Connection)
                    {
                        command.CommandType = CommandType.Text;
                        command.CommandText = string.Format("SELECT * FROM Reci WHERE Engleski = '{0}'", engleskaRec);

                        command.Connection.Open();

                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();

                            da.Fill(dt);

                            foreach (DataRow dr in dt.Rows)
                            {
                                Rec R = new Rec(dr);
                                SrpskeReci.Add(R);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
            }

            return SrpskeReci;
        }

        public bool DodajRec(Rec rec)
        {
            errMessage = "";

            try
            {
                using (SqlCommand command = SQLKonekcija.GetCommand)
                {
                    using (command.Connection)
                    {
                        command.CommandType = CommandType.Text;
                        command.CommandText = string.Format("INSERT INTO Reci (Srpski, Engleski, Opis) VALUES ('{0}', '{1}', '{2}')", rec.Srpski, rec.Engleski, rec.Opis);

                        command.Connection.Open();

                        command.ExecuteNonQuery();
                    }

                }

                return true;
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
            }

            return false;
        }
    }
}