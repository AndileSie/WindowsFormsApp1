using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class frmFault : Form
    {
        public frmFault()
        {
            InitializeComponent();
        }

        private void frmFualt_Load(object sender, EventArgs e)
        {
            cmbFaultType.Items.Add("Computer Lab");
            cmbFaultType.Items.Add("Computer Repairs");
            
            StreamReader read = new StreamReader("Student.txt");
            string line = "";
            string[] field;
            while ((line = read.ReadLine()) != null)
            {
                field = line.Split('#');
                cmbFaultType.Items.Add(field[0] + "\t" + field[1]);
            }
            read.Close();
            
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmMenu form = new frmMenu();
            form.Show();
            this.Hide();
        }
        int count = 1000000001;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            StreamWriter write = new StreamWriter("Fault.txt", true);
            write.WriteLine(txtFaultID.Text + "#" + txtFaultDesc.Text + "#" + cmbFaultType.Text + "#" + cmbStuReport.Text + "#" + cmbIntRes.Text);
            write.Close();
            count++;
            MessageBox.Show("This fault has been added!");

        }

        private void cmbFaultType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnList_Click(object sender, EventArgs e)
        {
            txtFaultID.Text = count.ToString();
            StreamReader read = new StreamReader("Fault.txt");
            string line = "";
            string[] field;
            while ((line = read.ReadLine()) != null)
            {
                field = line.Split('#');
                lstbFault.Items.Add(field[0] + "\t" + field[1] + "\t" + field[2] + "\t" + field[3] + "\t" + field[4]);
            }
            read.Close();
        }

        private void grbFault_Enter(object sender, EventArgs e)
        {

        }
    }
}
