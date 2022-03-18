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

        private void btnStudents_Click(object sender, EventArgs e)
        {
            frmStudent frn = new frmStudent();
            frn.Show();
            this.Hide();
        }

        private void btnFault_Click(object sender, EventArgs e)
        {
            frmFault fault = new frmFault();
            fault.Show();
            this.Hide();
        }

        private void btnFaultType_Click(object sender, EventArgs e)
        {
            frmFaultType faultype = new frmFaultType();
            faultype.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch search = new frmSearch();
            search.Show();
            this.Hide();
        }
    }
}
