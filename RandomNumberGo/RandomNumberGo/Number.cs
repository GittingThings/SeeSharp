namespace RandomNumberGo
{
    public partial class Number : Form
    {
        private int targetNum;

        //generating number
        public Number()
        {
            InitializeComponent();
            targetNum = genRanNum(1, 101);
        }

        // Random Number Generator, making new class
        private int genRanNum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        //button logic and checing to see if user input is a number
        private void button1_Click(object sender, EventArgs e)
        {
            string strUserGuess = Output.Text;
            string strMessage = "";

            if (int.TryParse(strUserGuess, out int userGuess))

                //if else statements for outputon guessing the number
            {
                if (userGuess == targetNum)
                {
                    strMessage = "Correct! You guessed the number.";
                }
                else if (userGuess < targetNum)
                {
                    strMessage = "Too low! Try again.";
                }
                else
                {
                    strMessage = "Too high! Try again.";
                }
            }
            else
            {
                strMessage = "Please enter a valid number.";
            }
            //label that changes the text below the input box, different from whats in the class as I switched it so that it displays to low or too high.
            label3.Text = strMessage;
        }
    }
}
