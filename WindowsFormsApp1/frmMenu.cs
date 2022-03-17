using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFault fault = new frmFault();
            fault.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStudent frn = new frmStudent();
            frn.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmFaultType fault = new frmFaultType();
            fault.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSearch fault = new frmSearch();
            fault.Show();
            this.Hide();
        }
    }
}
