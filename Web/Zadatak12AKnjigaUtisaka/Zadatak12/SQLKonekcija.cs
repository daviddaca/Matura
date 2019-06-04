using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Zadatak12
{
    public class SQLKonekcija
    {
        private static string ImeBaze = "KnjigaUtisaka";
        private static string Server = ".";
        private static string Username = "sa";
        private static string Password = "sqladmin";

        static SqlConnection GetConnection
        {
            get
            {
                return new SqlConnection(string.Format("Data source={0};Initial catalog={1};User id={2};Password={3}", Server, ImeBaze, Username, Password));
            }
        }


        public static SqlCommand GetCommand
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