using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace BaracVladimir
{
    public partial class Form2 : Form
    {
        SqlConnection konekcija = new SqlConnection("Data Source=R1-PC\\SQLEXPRESS;Initial Catalog=GOLF;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, System.EventArgs e)
        {
            konekcija.Open();
            SqlCommand com;
            SqlDataReader rd;
            string query = "Select * FROM IGRAC";
           
           
            try
            {
               
                MessageBox.Show("Konekcija je aktivna");
                com = new SqlCommand(query, konekcija);
                rd = com.ExecuteReader();
                while (rd.Read())
                {
                    string id = (string)rd["IGRACID"].ToString();
                    comboBox1.Text=id;

                    comboBox2.Items.Add(rd["GRADID"].ToString());
                   
                }
                com.Dispose();
                konekcija.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do Greske");
            }
   
          
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            konekcija.Open();
            SqlCommand com;
            SqlDataReader rd;
            string query = "INSERT INTO IGARC(IGRACID,IME,PREZIME,ADRESA,GRADID,EMAIL,TELEFON)VALUES("+comboBox1.Text+"," +textBox1.Text+"," +textBox2.Text+"," +textBox3.Text+"," +comboBox2.Text+"," +textBox4.Text+"," +textBox5.Text+")";
            try
            {
                  if ( comboBox1.Text=="" ||textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" ||comboBox2.Text=="" || textBox4.Text == "" || textBox5.Text == ""  || comboBox1.Text == ""){
                  MessageBox.Show("POPUNITE SVA POLJA");
                       return;
                      else{
                      
                      SqlCommand c=new SqlCommand("select IGRADID  from IGRAC  where ");
                      }
                  }
            }
            
            }
            
            
        }
    }
}
