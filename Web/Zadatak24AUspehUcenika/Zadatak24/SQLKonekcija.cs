using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Zadatak24
{
    public class SQLKonekcija
    {
        static SqlConnection GetConnection
        {
            get
            {
                string username = ConfigurationManager.AppSettings.Get("Username");
                string password = ConfigurationManager.AppSettings.Get("Password");
                string server = ConfigurationManager.AppSettings.Get("Server");
                string database = ConfigurationManager.AppSettings.Get("Database");

                return new SqlConnection(string.Format("Data source={0};Initial catalog={1};User id={2};Password={3}", server, database, username, password));
            }
        }

        public static SqlCommand GetSqlCommand
        {
            get
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SQLKonekcija.GetConnection;
                return cmd;
            }
        }
    }
}