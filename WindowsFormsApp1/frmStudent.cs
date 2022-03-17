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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }
        int idNum = 1000001;
        private void frmStudent_Load(object sender, EventArgs e)
        {
            txtUserID.Enabled = false;
            txtUserID.Text = idNum.ToString();
            cmbRole.Items.Add("Student");
            cmbRole.Items.Add("Intern");
            cmbYearOfStudy.Items.Add("First Year");
            cmbYearOfStudy.Items.Add("Second Year");
            cmbYearOfStudy.Items.Add("Third Year");
            lblYearOfStudy.Visible = false;
            cmbYearOfStudy.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbRole.SelectedItem.ToString() == "Student")
            {
                StreamWriter student = new StreamWriter("Student.txt", true);

                student.WriteLine(txtUserID.Text + "#" + txtName.Text + "#" + txtSurname.Text + "#" + dtpDOB.Text + "#" + cmbRole.SelectedItem.ToString() + "#" + cmbYearOfStudy.SelectedItem.ToString());

                student.Close();
            }
            else if (cmbRole.SelectedItem.ToString() == "Intern")
            {
                StreamWriter intern = new StreamWriter("Intern.txt", true);

                intern.WriteLine(txtUserID.Text + "#" + txtName.Text + "#" + txtSurname.Text + "#" + dtpDOB.Text + "#" + cmbRole.SelectedItem.ToString());

                intern.Close();
            }
            txtUserID.Clear();
            txtName.Clear();
            txtSurname.Clear();
            cmbRole.ResetText();
            cmbYearOfStudy.ResetText();
            MessageBox.Show("Record Successfully Added!");

            idNum++;
            txtUserID.Text = idNum.ToString();

            lblYearOfStudy.Visible = false;
            cmbYearOfStudy.Visible = false;

            lstDisplayItems.Items.Clear();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lstDisplayItems.Items.Add("User ID" + "\t" + "User Name" + "\t" + "User Surname" + "\t" + "Date of Birth" + "\t\t" + "Role" + "\t" + "Year of Study");

            StreamReader student = new StreamReader("Student.txt");
            string line = "";
            string[] record;

            while ((line = student.ReadLine()) != null)
            {
                record = line.Split('#');
                lstDisplayItems.Items.Add(record[0] + "\t" + record[1] + "\t\t" + record[2] + "\t\t" + record[3] + "\t" + record[4] + "\t" + record[5]);
            }
            student.Close();

            StreamReader intern = new StreamReader("Intern.txt");
            string row = "";
            string[] field;

            while ((row = intern.ReadLine()) != null)
            {
                field = row.Split('#');
                lstDisplayItems.Items.Add(field[0] + "\t" + field[1] + "\t\t" + field[2] + "\t\t" + field[3] + "\t" + field[4]);
            }
            intern.Close();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
            
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedItem.ToString() == "Student")
            {
                lblYearOfStudy.Visible = true;
                cmbYearOfStudy.Visible = true;
            }
            else if (cmbRole.SelectedItem.ToString() == "Intern")
            {
                lblYearOfStudy.Visible = false;
                cmbYearOfStudy.Visible = false;
            }
        }

        private void cmbYearOfStudy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstDisplayItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
