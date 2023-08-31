using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMO_Gear_Comparison_App
{
    public partial class GearComparisonForm : Form
    {
        public GearComparisonForm()
        {
            InitializeComponent();
        }

        private void GearComparisonForm_Load(object sender, EventArgs e)
        {
            PopulateGearList();
        }

        private void PopulateGearList()
        {
            cboFirstGear.Items.Clear();
            cboSecondGear.Items.Clear();

            try
            {
                using GearContext dbContext = new GearContext();

                List<Gear> gearList = dbContext.Gears.ToList();

                foreach (Gear g in gearList)
                {
                    cboFirstGear.Items.Add(g.ItemName);
                    cboSecondGear.Items.Add(g.ItemName);
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Database is not available. PLease try again later", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
            }
        }

        private void btnCompareGear_Click(object sender, EventArgs e)
        {
            // Validation to make sure a gear is selected
            if (cboFirstGear.SelectedIndex == -1)
            {
                MessageBox.Show("First gear must be selected");
            }
            if (cboSecondGear.SelectedIndex == -1)
            {
                MessageBox.Show("Second gear must be selected");
            }
        }

        // When the user changes their gear selection - first gear
        private void cboFirstGear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // When the user changes their gear selection - second gear
        private void cboSecondGear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PopulateGearStats()
        {

        }

        private void btnExitGearComparison_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClearSelectedGear_Click(object sender, EventArgs e)
        {
            cboFirstGear.SelectedIndex = -1;
            cboSecondGear.SelectedIndex = -1;
        }
    }
}
