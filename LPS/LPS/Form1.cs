namespace LPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            string sMaxNum = txtMaxNum.Text;
            int iMaxNum;

            if (!int.TryParse(sMaxNum, out iMaxNum))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            lbCountdown.Items.Clear();

            // Countdown loop
            for (int i = iMaxNum; i >= 0; i--)
            {
                lbCountdown.Items.Add(i.ToString());
            }

            // 
            int[] arrIsales = { 20, 30, 40, 30, 20, 10 };
            int iTotalSales = 0;

            for (int i = 0; i < arrIsales.Length; i++)
            {
                lbCountdown.Items.Add($"Week {i + 1}: {arrIsales[i]} sales");
                iTotalSales += arrIsales[i];
            }

            lbCountdown.Items.Add($"Total Sales: ${iTotalSales}");
        }

        private void btnWhileLoop_Click(object sender, EventArgs e)
        {
            string sMaxNum = txtMaxNum.Text;
            int iMaxNum;

            if (!int.TryParse(sMaxNum, out iMaxNum))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            lbCountdown.Items.Clear();

            while (iMaxNum >= 0)
            {
                lbCountdown.Items.Add(iMaxNum.ToString());
                iMaxNum--;
            }
        }
    }
}
