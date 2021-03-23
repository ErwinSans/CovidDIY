using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidDIY
{
    public partial class SelectDataGrid : Form
    {
        private string kabupaten;
        private string suspected;
        private string exposed;

        public SelectDataGrid(string kabupaten, string exposed)
        {
            InitializeComponent();
        }

        public SelectDataGrid(string kabupaten, string suspected, string exposed, string infected, string recovered, string dead) : this(kabupaten, exposed)
        {

            InitializeComponent();
            label2.Text = kabupaten;
            label3.Text = exposed;
            label4.Text = infected;
            label5.Text = recovered;
            label6.Text = recovered;
            label7.Text = dead;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
