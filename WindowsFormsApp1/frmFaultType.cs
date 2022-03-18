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
    public partial class frmFaultType : Form
    {
        public frmFaultType()
        {
            InitializeComponent();
        }
        int idNum = 10002;
        private void frmFaultType_Load(object sender, EventArgs e)
        {
            txtFaultId.Enabled = false;
            try
            {
                double max = double.MinValue;
                StreamReader reader = new StreamReader("FaultType.txt");
                string[] field;
                while (reader.EndOfStream == false)
                {
                    field = reader.ReadLine().Split('#');
                    max = Math.Max(max, double.Parse(field[0]));
                }
                reader.Close();
                idNum = (int)max + 1;
                txtFaultId.Text = idNum.ToString();
            }
            catch
            {
                txtFaultId.Text = idNum.ToString();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StreamWriter write = new StreamWriter("FaultType.txt", true);

            write.WriteLine(txtFaultId.Text + "#" + txtFaultDesc.Text);
            write.Close();
            idNum++;
            txtFaultId.Text = idNum.ToString();
            MessageBox.Show("This Fault Type has been added!");
            txtFaultDesc.Text = "";
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lstFaults.Items.Clear();


            StreamReader read = new StreamReader("FaultType.txt");
            string line = "";
            string[] array;
            lstFaults.Items.Add("Fault Type ID\tFault Type Desc");

            while ((line = read.ReadLine()) != null)
            {
                array = line.Split('#');
                lstFaults.Items.Add(array[0] + "\t\t" + array[1]);
            }
            read.Close();
        }

        private void lstFaults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
