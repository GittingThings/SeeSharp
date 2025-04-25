namespace D_D_Character_Maker
{
    public partial class Mainfrm : Form
    {
        public Mainfrm()
        {
            InitializeComponent();
        }


        private void CISpec_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CISpec.Text == "Warrior")
            {
                lbl1.Text = "Weapon";
                lbl2.Text = "Armor";
            }
            else if (CISpec.Text == "Mage")
            {
                lbl1.Text = "Element";
                lbl2.Text = "Mana";
            }
        }


        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            string name = CIName.Text;
            string race = CIRace.Text;
            int health = (int)CIHealth.Value;
            int level = (int)CILevel.Value;
            string specialty = CISpec.Text;
            string spec1 = CISpec1.Text;
            int spec2 = (int)CISpec2.Value;

            if (specialty.Length > 0)
            {

                if (specialty == "Warrior")
                {
                    Warrior newWarrior = new Warrior(name, health, level, race, spec1, spec2);
                    LBMain.Items.Add($"{newWarrior.Attack()}");

                }
                else
                {
                    Mage newMage = new Mage(name, health, level, race, spec1, spec2);
                    LBMain.Items.Add($"{newMage.Attack()}");
                }


            }
            else
            {
                Character newChar = new Character(name, health, level, race);


            }
        }

        
    }
}
