using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PozorisnePredstave
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection("Data Source=R1-PC\\SQLEXPRESS;Initial Catalog=PREDSTAVE;Integrated Security=True");

            try
            {
                conn.Open();

                string query = "SELECT KOMADID, NAZIV FROM POZORISNIKOMAD ORDER BY KOMADID ASC";

                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read()){
                    comboBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString());
                }
                reader.Close();

                query = "SELECT PRODUCENTID, IME, PREZIME FROM PRODUCENT";

                command = new SqlCommand(query, conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox2.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " +reader[2].ToString());
                }
                reader.Close();

                query = "SELECT TRUPAID, NAZIVTRUPE FROM POZORISNATRUPA";

                command = new SqlCommand(query, conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox3.Items.Add(reader[0].ToString() + " " + reader[1].ToString());
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=R1-PC\\SQLEXPRESS;Initial Catalog=PREDSTAVE;Integrated Security=True");
            try
            {
                conn.Open();
                if (radioButton1.Checked)
                {
                    if (comboBox1.Text == "" || dateTimePicker1.CustomFormat == "__/__/____" || textBox1.Text == "" || textBox2.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
                    {
                        MessageBox.Show("Niste uneli sve podatke vezane za upis");
                    }
                    else
                    {
                        int idKom = int.Parse(comboBox1.Text.Split(null)[0]);
                        int brMesta = int.Parse(textBox1.Text);
                        float cena = float.Parse(textBox2.Text);
                        int producent = int.Parse(comboBox2.Text.Split(null)[0]);
                        int trupa = int.Parse(comboBox3.Text.Split(null)[0]);

                        string query = "INSERT INTO PREDSTAVA VALUES(" + idKom + ", '" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "', '" + brMesta + "', '" + cena + "', '"+producent+"', '"+trupa+"') ";

                        SqlCommand com = new SqlCommand(query, conn);
                        if (com.ExecuteNonQuery() != 0)
                        {
                            MessageBox.Show("Uspesno dodata predstava");
                        }
                        else
                        {
                            MessageBox.Show("Nije dodata predstava");
                        }
                    }
                }
                else if (radioButton2.Checked)
                {
                    if (comboBox1.Text != "" || dateTimePicker1.CustomFormat != "__/__/____")
                    {
                        string query = "";
                        
                        if (comboBox1.Text != "" && dateTimePicker1.CustomFormat != "__/__/____")
                        {
                            int idKom = int.Parse(comboBox1.Text.Split(null)[0]);
                            query = "DELETE FROM PREDSTAVA WHERE KOMADID = " + idKom + " AND DATUM = '" + dateTimePicker1.Value + "'";
                        }
                        else if (comboBox1.Text != "" && dateTimePicker1.CustomFormat == "__/__/____")
                        {
                            int idKom = int.Parse(comboBox1.Text.Split(null)[0]);
                            query = "DELETE FROM PREDSTAVA WHERE KOMADID = " + idKom;
                        }
                        else if (comboBox1.Text == "" && dateTimePicker1.CustomFormat != "__/__/____")
                        {
                            query = "DELETE FROM PREDSTAVA WHERE DATUM = '" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "'";
                        }

                        SqlCommand com = new SqlCommand(query, conn);
                        var confirmResult = MessageBox.Show("Da li zelite da obrisete predstavu?", "Brisanje",
                                         MessageBoxButtons.YesNo);

                        if (confirmResult == DialogResult.Yes)
                        {
                            if (com.ExecuteNonQuery() != 0)
                            {
                                MessageBox.Show("Uspesno brisanje");
                            }
                            else
                            {
                                MessageBox.Show("Greska prilikom brisanja");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Unesite komad ili datum");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode == Keys.Back)||(e.KeyCode==Keys.Delete)){
                dateTimePicker1.CustomFormat ="__/__/____";
            }
        }
    }
}
