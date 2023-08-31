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

        private void btnExitGearComparison_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
