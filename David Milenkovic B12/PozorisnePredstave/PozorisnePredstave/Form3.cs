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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection("Data Source=R1-PC\\SQLEXPRESS;Initial Catalog=PREDSTAVE;Integrated Security=True");

            try
            {
                conn.Open();

                string query = "SELECT * FROM POZORISNIKOMAD ORDER BY KOMADID ASC";

                var dataAdapter = new SqlDataAdapter(query, conn);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i);
                comboBox3.Items.Add(i);
            }

            for (int i = 1; i <= 12; i++)
            {
                comboBox2.Items.Add(i);
                comboBox4.Items.Add(i);
            }
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

                string komadid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string dateod = textBox1.Text + "-" + comboBox2.Text + "-" + comboBox1.Text;
                string datedo = textBox2.Text + "-" + comboBox4.Text + "-" + comboBox3.Text;
                DateTime oDate = DateTime.Parse(dateod);
                DateTime dDate = DateTime.Parse(datedo);
                if (datum()&&(dDate>oDate))
                {
                    string query = "SELECT NAZIVTRUPE, CENAKARTE, BROJMESTA FROM PREDSTAVA INNER JOIN POZORISNATRUPA ON POZORISNATRUPA.TRUPAID = PREDSTAVA.TRUPAID WHERE PREDSTAVA.KOMADID = '" + komadid + "' AND DATUM BETWEEN '" + dateod + "' AND '" + datedo + "'";

                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] arr = new string[3];
                        ListViewItem itm;
                        //add items to ListView
                        arr[0] = reader[0].ToString();
                        arr[1] = (int.Parse(reader[1].ToString()) * int.Parse(reader[2].ToString())).ToString();
                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Datum je neispravan");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            
        }

        private bool datum()
        {
            if(int.Parse(comboBox2.Text)<1||int.Parse(comboBox2.Text)>12)
                return false;
            if (int.Parse(comboBox4.Text) < 1 || int.Parse(comboBox4.Text) > 12)
                return false;

            switch (int.Parse(comboBox2.Text))
            {
                case 1: case 3: case 5: case 7:case 8:case 10:case 12:
                    if(int.Parse(comboBox1.Text)<1||int.Parse(comboBox1.Text)>31)
                        return false;
                    break;
                case 4:case 6:case 9:case 11:
                    if(int.Parse(comboBox1.Text)<1||int.Parse(comboBox1.Text)>30)
                        return false;
                    break;
                case 2:
                    if(int.Parse(comboBox1.Text)<1||int.Parse(comboBox1.Text)>29)
                        return false;
                    break;
            }
            switch (int.Parse(comboBox4.Text))
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (int.Parse(comboBox3.Text) < 1 || int.Parse(comboBox3.Text) > 31)
                        return false;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (int.Parse(comboBox3.Text) < 1 || int.Parse(comboBox3.Text) > 30)
                        return false;
                    break;
                case 2:
                    if (int.Parse(comboBox3.Text) < 1 || int.Parse(comboBox3.Text) > 29)
                        return false;
                    break;
            }
            return true;
        }
    }
}
