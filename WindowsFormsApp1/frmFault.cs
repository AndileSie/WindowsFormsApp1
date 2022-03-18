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
            //cmbFaultType.Items.Add("Computer Lab");
            //cmbFaultType.Items.Add("Computer Repairs");
            
            StreamReader read = new StreamReader("Student.txt");
            string line = "";
            string[] field;
            while ((line = read.ReadLine()) != null)
            {
                field = line.Split('#');
                cmbStuReport.Items.Add(field[1] + "  " + field[2]);
            }
            read.Close();
            read = new StreamReader("Intern.txt");
            while (read.EndOfStream == false)
            {
                field = read.ReadLine().Split('#');
                cmbIntRes.Items.Add(field[1] + "   " + field[2]);
            }
            read.Close();
            read = new StreamReader("FaultType.txt");
            while (read.EndOfStream == false)
            {
                field = read.ReadLine().Split('#');
                cmbFaultType.Items.Add(field[1]);
            }
            read.Close();
            //starts here
            try
            {
                double max = double.MinValue;
                StreamReader reader = new StreamReader("Fault.txt");
                while (reader.EndOfStream == false)
                {
                    field = reader.ReadLine().Split('#');
                    max = Math.Max(max, double.Parse(field[0]));
                }
                reader.Close();
                idNum = (int)max + 1;
                txtFaultID.Text = idNum.ToString();
            }
            catch
            {
                txtFaultID.Text = idNum.ToString();

            }

            //ends here
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmMenu form = new frmMenu();
            form.Show();
            this.Hide();
        }
        int idNum = 1000000001;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            StreamWriter write = new StreamWriter("Fault.txt", true);
            write.WriteLine(txtFaultID.Text + "#" + txtFaultDesc.Text + "#" + cmbFaultType.Text + "#" + cmbStuReport.Text + "#" + cmbIntRes.Text);
            write.Close();
            idNum++;
            txtFaultID.Text = idNum.ToString();
            MessageBox.Show("This fault has been added!");
            txtFaultDesc.Text = "";
            cmbFaultType.Text = "";
            cmbIntRes.Text = "";
            cmbStuReport.Text = "";

        }

        private void cmbFaultType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnList_Click(object sender, EventArgs e)
        {
            //txtFaultID.Text = idNum.ToString();
            lstbFault.Items.Clear();
            //lstDisplayItems.Items.Add("User ID" + "\t" + "User Name" + "\t" + "User Surname" + "\t" + "Date of Birth" + "\t\t" + "Role" + "\t" + "Year of Study");

            lstbFault.Items.Add("Fault ID" + "\t\t" + "Fault Desc" + "\t" + "Fault Type" + "\t" + "Student Reporting" + "\t" + "Intern Responsible");
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
