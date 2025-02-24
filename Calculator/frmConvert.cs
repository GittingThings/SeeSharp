namespace Calculator
{
    public partial class frmConvert : Form
    {
        public frmConvert()
        {
            InitializeComponent();
        }

        private void txtinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbloutput_Click(object sender, EventArgs e)
        {

        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            //
            string snumberInput = txtinput.Text;
            //
            double dnumberInput = 0;

            double dnumberOutput = 0;

            //testing to see if there are letters in the input
            if (!double.TryParse(snumberInput, out dnumberInput))
            {   //Error upon entering letters
                lbloutput.Text = "Invalid input";
            }
            else
            {   //multipling
                dnumberOutput = Convert.ToDouble(snumberInput) * 2;
                //output in label
                lbloutput.Text = "Number: " + dnumberOutput;
            }


        }
    }
}
