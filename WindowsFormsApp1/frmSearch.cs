using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.ShowDialog();
        }
        //1000002
        private void txtStudent_TextChanged(object sender, EventArgs e)
        {
            bool stop = false;
            StreamReader student = new StreamReader("Student.txt");
            
            while (student.EndOfStream == false)
            {
                string[] record = student.ReadLine().Split('#');
                if (record[0] == txtStudent.Text)
                {
                    lstDisplayItems.Items.Add("User ID" + "\t" + "User Name" + "\t" + "User Surname" + "\t" + "Date of Birth" + "\t\t" + "Role" + "\t" + "Year of Study");
                    lstDisplayItems.Items.Add(record[0] + "\t" + record[1] + "\t\t" + record[2] + "\t\t" + record[3] + "\t" + record[4] + "\t" + record[5]);
                    stop = true;
                    break;
                }
                else
                {
                    lstDisplayItems.Items.Clear();
                }
            }
            student.Close();

            StreamReader intern = new StreamReader("Intern.txt");
            while (intern.EndOfStream == false)
            {
                string[] record = intern.ReadLine().Split('#');
                if (record[0] == txtStudent.Text)
                {
                    lstDisplayItems.Items.Add("User ID" + "\t" + "User Name" + "\t" + "User Surname" + "\t" + "Date of Birth" + "\t\t" + "Role" + "\t" + "Year of Study");
                    lstDisplayItems.Items.Add(record[0] + "\t" + record[1] + "\t\t" + record[2] + "\t\t" + record[3] + "\t" + record[4]);
                    break;
                }
                else if (stop == false)
                {
                    lstDisplayItems.Items.Clear();
                }
            }
            intern.Close();
            
        }
    }
}
