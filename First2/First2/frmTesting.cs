using System.Diagnostics;

namespace First2
{
    public partial class frmTesting : Form
    {
        public frmTesting()
        {
            InitializeComponent();
        }
        //wiring the button
        private void btnStart_Click(object sender, EventArgs e)
        {
            //create a stopwatch
            Stopwatch watch = new Stopwatch();
            //timer start
            watch.Start();
            //size of the Array
            int iSize = int.Parse(txtArraySize.Text);


            //Array Creation
            int[] arInts = new int[iSize];


            //Loop Creation
            for (int i = 0; i < iSize; i++)
            {
                Thread.Sleep(100);
                //add a delay
            }
            //Timer stop
            watch.Stop();

            //shows how many miliseconds it took th program to run
            MessageBox.Show("The execution time was: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}
