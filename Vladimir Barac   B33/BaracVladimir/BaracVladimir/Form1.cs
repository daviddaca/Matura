using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace BaracVladimir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection konekcija = new SqlConnection("Data Source=R1-PC\\SQLEXPRESS;Initial Catalog=GOLF;Integrated Security=True");

        
     
        private void igraciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void spisakTerenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void krajRadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void izlazALTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
