using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace LPS
{
    public partial class frmFileOps : Form
    {
        public frmFileOps()
        {
            InitializeComponent();
        }

        private string filename = "example.txt;";
        //hiding form and opening new one
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();

            Form1.Show();

            this.Hide();
        }

        private void frmFileOps_Load(object sender, EventArgs e)
        {

        }
        //calling on the function to make a file
        private void btnSave_Click(object sender, EventArgs e)
        {
            writeToFile();
        }
        //function to make a file
        private void writeToFile()
        {

            try
            {
                File.WriteAllText(filename, txtInputOps.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //button calling on a function
        private void btnRead_Click(object sender, EventArgs e)
        {
            readFromFile();
        }


        //reading the file
        private void readFromFile()
        {
            if (File.Exists(filename))
            {
                lblFileContents.Text = File.ReadAllText(filename);
            }
            else
            {
                MessageBox.Show("The file was not found");
            }

        }
        //going to another form
        private void btnSeeForm_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();

            Form2.Show();

            this.Hide();
        }
    }
}
