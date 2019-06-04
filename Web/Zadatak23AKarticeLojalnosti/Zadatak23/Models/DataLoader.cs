using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Zadatak23.Models
{
    public class DataLoader
    {
        public string _ErrorMessage;

        public DataLoader()
        {
            //
        }

        public string ErrorMessage
        {
            get { return _ErrorMessage; }
        }

        public LoyaltyCard LoadCard(string BrojKartice)
        {
            LoyaltyCard card = new LoyaltyCard();

            try
            {                
                using (SqlCommand cmd = SQLKonekcija.GetSqlCommand)
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Kartice WHERE [Broj Kartice] = @broj_kartice";
                    cmd.Parameters.AddWithValue("@broj_kartice", BrojKartice);

                    DataTable table = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    cmd.Connection.Open();

                    da.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        card.BrojKartice = table.Rows[0]["Broj Kartice"].ToString();
                        card.ImeVlasnika = table.Rows[0]["Ime Vlasnika"].ToString();
                        card.PrezimeVlasnika = table.Rows[0]["Prezime Vlasnika"].ToString();
                        card.AdresaVlasnika = table.Rows[0]["Adresa Vlasnika"].ToString();
                        card.OstvareniBodovi = Convert.ToDouble(table.Rows[0]["Ostvareni Bodovi"]);
                        card.OstvareniPopust = Convert.ToDouble(table.Rows[0]["Ostvareni Popust"]);
                        card.RokVazenja = Convert.ToDouble(table.Rows[0]["Rok Vazenja"]);                       
                    }
                    else
                    {
                        card.ErrorMessage = "Kartica ne postoji u sistemu.";                       
                    }
                }
            }
            catch (Exception ex)
            {
                _ErrorMessage = ex.GetBaseException().Message;
                card.ErrorMessage = _ErrorMessage;   
            }

            return card;
        }

    }
}