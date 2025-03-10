using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace LPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // For loop button click
        private void btnFor_Click(object sender, EventArgs e)
        {
            try
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

                // Sales loop
                int[] arrIsales = { 20, 30, 40, 30, 20, 10 };
                int iTotalSales = 0;

                for (int i = 0; i < arrIsales.Length; i++)
                {
                    lbCountdown.Items.Add($"Week {i + 1}: {arrIsales[i]} sales");
                    iTotalSales += arrIsales[i];
                }

                lbCountdown.Items.Add($"Total Sales: ${iTotalSales}");
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("An unexpected error occurred. Please try again.");
            }
        }

        // While loop button click
        private void btnWhileLoop_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("An occurred: " + ex.Message);
            }
        }

        // Private method to log errors
        private void LogError(Exception ex)
        {
            string sLogFilePath = "error_log.txt";

            string sErrorMessage = $"{DateTime.Now}: {ex.Message}";

            try
            {
                File.AppendAllText(sLogFilePath, sErrorMessage);
            }

            catch (IOException exIO)
            {
                MessageBox.Show("File access issue" + exIO.Message);
            }
            catch (Exception exDefault)
            {
                MessageBox.Show("Other issue: " + exDefault.Message);
            }
        }
    }
}
