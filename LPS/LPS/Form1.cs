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

                //Array set up
                string[] arrWeekdays = ["Parmesan", "Cheddar", "Swiss", "Provolone", "Brie", "Feta", "Mozzerella"];

                for (int i= 0; i < arrWeekdays.Length; i++)
                {
                    lbCountdown.Items.Add(arrWeekdays[i]);
                }

                //double array
                double[] arrTemps = [200.8, 57.6, 56.3, 2.6, 37.2, 45.4, 7.5];

                for (int i = 0; i < arrWeekdays.Length; i++)
                {
                    lbCountdown.Items.Add($"{arrWeekdays[i]}: {arrTemps[i]}");
                }

                //two dimensional array

                double[,] arrTempsHiLow =
                {
                    { 22.2, 33.3 }, //Parmesan
                    { 77.2, 73.3 }, //Cheddar
                    { 42.7, 93.4 }, //Swiss
                    { 29.2, 33.9 }, //Provolone
                    { 20.3, 34.8 }, //Brie
                    { 32.2, 33.7 }, //Feta
                    { 28.6, 63.3 } //Mozzerella
                };

                const int High = 0;
                const int Low = 1;

                for (int i = 0; i < arrWeekdays.Length; i++)
                {
                    lbCountdown.Items.Add($"{arrWeekdays[i]}: High: {arrTempsHiLow[i, High]}: Low: {arrTempsHiLow[i, Low]}");
                }

                int[,] arrStuffInfo = new int[5, 2];

                const int StuffNum = 0;
                const int StuffQty = 1;

                arrStuffInfo[0, StuffNum] = 1001;
                arrStuffInfo[0, StuffQty] = 16;

                arrStuffInfo[1, StuffNum] = 1002;
                arrStuffInfo[1, StuffQty] = 19;

                arrStuffInfo[2, StuffNum] = 1003;
                arrStuffInfo[2, StuffQty] = 12;

                arrStuffInfo[3, StuffNum] = 1004;
                arrStuffInfo[3, StuffQty] = 14;

                arrStuffInfo[4, StuffNum] = 1005;
                arrStuffInfo[4, StuffQty] = 15;

                //loop through the data and print it
                for (int i = 0; i < arrStuffInfo.GetLength(0); i++)
                {

                    //j= colums
                    for (int j = 0; j < arrStuffInfo.GetLength(1); j++)
                    {
                        lbCountdown.Items.Add($"i={i}:j={j}: Stuff Info: {arrStuffInfo[i, j]}");
                    }



                }


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
