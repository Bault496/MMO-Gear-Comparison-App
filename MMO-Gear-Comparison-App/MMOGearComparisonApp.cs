namespace MMO_Gear_Comparison_App
{
    public partial class MMOGearComparisonForm : Form
    {
        public MMOGearComparisonForm()
        {
            InitializeComponent();
        }

        private void btnCompareGear_Click(object sender, EventArgs e)
        {
            GearComparisonForm gearComparison = new GearComparisonForm();
            gearComparison.ShowDialog();
        }

        private void btnManageGear_Click(object sender, EventArgs e)
        {
            ManageGearForm manageGear = new ManageGearForm();
            manageGear.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}