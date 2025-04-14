namespace Classes
{
    public partial class Cls : Form
    {
        public Cls()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create a character

            Recipe newRecipe = new Recipe(textBox1.Text, textBox2.Text, 10, textBox3.Text, true, textBox4.Text);

            lbRecipes.Items.Add(newRecipe.Name + ", " + newRecipe.Category + ", Level:" + newRecipe.Level + ", Specialty:" + newRecipe.Specialty + ", Author:" + newRecipe.SubmittedBy);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
