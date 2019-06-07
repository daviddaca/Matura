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

            string query2 = "SELECT * FROM GRAD";
            try
            {
               
                MessageBox.Show("Konekcija je aktivna");
                com = new SqlCommand(query, konekcija);
                rd = com.ExecuteReader();
                while (rd.Read())
                {
                    //string id = (string)rd["IGRACID"].ToString();
                    //comboBox1.Text=id;

                    //comboBox2.Items.Add(rd["GRADID"].ToString());
                    comboBox1.Items.Add(rd[0].ToString());
                }
                com = new SqlCommand(query2, konekcija);
                rd = com.ExecuteReader();
                while (rd.Read())
                {
                    //string id = (string)rd["IGRACID"].ToString();
                    //comboBox1.Text=id;

                    //comboBox2.Items.Add(rd["GRADID"].ToString());
                    comboBox2.Items.Add(rd[0].ToString());
                }
                rd.Close();

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

            SqlCommand com2;
            string query2 = "Select GRADID FROM GRAD WHERE GRAD = '"+comboBox2.Text+"'";
            com2 = new SqlCommand(query2, konekcija);
            int id = (int)com2.ExecuteScalar();

            SqlCommand com;
            SqlDataReader rd;
            string query = "INSERT INTO IGRAC(IGRACID,IME,PREZIME,ADRESA,GRADID,EMAIL,TELEFON) VALUES ('"+comboBox1.Text+"','" +textBox1.Text+"','" +textBox2.Text+"','" +textBox3.Text+"','" +id.ToString()+"','" +textBox4.Text+"','" +textBox5.Text+"')";
            try
            {
                com = new SqlCommand(query, konekcija);
                com.ExecuteNonQuery();
                MessageBox.Show("Upis gotov");
            }
            catch (Exception ex) {
                MessageBox.Show("NE RADIIIIIi");
            }
            
            
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            konekcija.Open();
            SqlCommand com;
            SqlDataReader rd;
            string query = "Select * FROM IGRAC";

            string query2 = "SELECT * FROM GRAD ORDER BY GRAD ASC";
            try
            {

                MessageBox.Show("Konekcija je aktivna");
                com = new SqlCommand(query, konekcija);
                rd = com.ExecuteReader();
                while (rd.Read())
                {
                    //string id = (string)rd["IGRACID"].ToString();
                    //comboBox1.Text=id;

                    //comboBox2.Items.Add(rd["GRADID"].ToString());
                    comboBox1.Items.Add(rd[0].ToString());
                }
                rd.Close();
                SqlCommand com2 = new SqlCommand(query2, konekcija);
                SqlDataReader rd2 = com2.ExecuteReader();
                while (rd2.Read())
                {
                    //string id = (string)rd["IGRACID"].ToString();
                    //comboBox1.Text=id;

                    //comboBox2.Items.Add(rd["GRADID"].ToString());
                    comboBox2.Items.Add(rd2[1].ToString());
                }
                rd2.Close();

                com2.Dispose();
                konekcija.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do Greske");
            }
   
          
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
