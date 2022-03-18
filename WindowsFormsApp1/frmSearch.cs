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
            menu.Show();
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
                    lstDisplayItems.Items.Add("User ID" + "\t" + "User Name" + "\t" + "User Surname" + "\t" + "Date of Birth" + "\t\t" + "Role");
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

        private void txtFault_TextChanged(object sender, EventArgs e)
        {
            StreamReader fault = new StreamReader("Fault.txt");
            while (fault.EndOfStream == false)
            {
                string[] field = fault.ReadLine().Split('#');
                if (field[0] == txtFault.Text)
                {
                    lstDisplayItems.Items.Add("Fault ID" + "\t\t" + "Fault Desc" + "\t\t" + "Fault Type" + "\t\t" + "Student Reporting" + "\t" + "Intern Responsible");

                    lstDisplayItems.Items.Add(field[0] + "\t" + field[1] + "\t" + field[2] + "\t" + field[3] + "\t" + field[4]);
                    break;
                }
                else
                {
                    lstDisplayItems.Items.Clear();
                }
            }
            fault.Close();

        }

        private void txtFaultType_TextChanged(object sender, EventArgs e)
        {
            StreamReader read = new StreamReader("FaultType.txt");
            while (read.EndOfStream == false)
            {
                string[] array = read.ReadLine().Split('#');
                if (array[0] == txtFaultType.Text)
                {
                    lstDisplayItems.Items.Add("Fault Type ID\tFault Type Desc");
                    lstDisplayItems.Items.Add(array[0] + "\t\t" + array[1]);
                    break;
                }
                else
                {
                    lstDisplayItems.Items.Clear();
                }
            }
            read.Close();
        }

        private void btnFaultType_Click(object sender, EventArgs e)
        {
            bool stop = false;
            StreamReader read = new StreamReader("FaultType.txt");
            while (read.EndOfStream == false)
            {
                string[] array = read.ReadLine().Split('#');
                if (array[0] == txtFaultType.Text)
                {
                    lstDisplayItems.Items.Add("Fault Type ID\tFault Type Desc");
                    lstDisplayItems.Items.Add(array[0] + "\t\t" + array[1]);
                    stop = true;
                    break;
                }
                
            }
            read.Close();
            if (stop == false)
            {
                lstDisplayItems.Items.Add("Record Not Found");
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
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
                    stop = true;
                    break;
                }
                
            }
            intern.Close();
            if (stop == false)
            {
                lstDisplayItems.Items.Add("Record Not Found");
            }
        }

        private void btnFault_Click(object sender, EventArgs e)
        {
            bool stop = false;
            StreamReader fault = new StreamReader("Fault.txt");
            while (fault.EndOfStream == false)
            {
                string[] field = fault.ReadLine().Split('#');
                if (field[0] == txtFault.Text)
                {
                    lstDisplayItems.Items.Add("Fault ID" + "\t\t" + "Fault Desc" + "\t\t" + "Fault Type" + "\t\t" + "Student Reporting" + "\t" + "Intern Responsible");
                    lstDisplayItems.Items.Add(field[0] + "\t" + field[1] + "\t" + field[2] + "\t" + field[3] + "\t" + field[4]);
                    stop = true;
                    break;
                }
                else
                {
                    lstDisplayItems.Items.Add("Record Not Found");
                }
            }
            fault.Close();
            if (stop == false)
            {
                lstDisplayItems.Items.Add("Record Not Found");
            }
        }
    }
}
