using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void btnConvert_Click(object sender, EventArgs e)
        {

            string snumberInput = txtinput.Text;

            double dnumberInput = 0;

            double dnumberOutput = 0;

            //checking for letters and making the new output the doubled number
            if (!double.TryParse(snumberInput, out dnumberInput))
            {
                lbloutput.Text = "Invalid input";
            }
            else
            {
                dnumberOutput = Convert.ToDouble(snumberInput) * 2;

                lbloutput.Text = "Number: " + dnumberOutput;
            }
        }
        //going to previous form
        private void btnExit_Click(object sender, EventArgs e)
        {
            frmFileOps frmFileOps = new frmFileOps();

            frmFileOps.Show();

            this.Hide();
        }
    }
}
