using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaracVladimir
{
    public partial class Form3 : Form
    {
      
        public Form3()
        {
            InitializeComponent();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

      
    }
}
