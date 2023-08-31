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
    public partial class EditGearForm : Form
    {
        public EditGearForm()
        {
            InitializeComponent();
        }

        private void btnEditGear_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditGearForm_Load(object sender, EventArgs e)
        {
            PopulateGearList();
        }
        /// <summary>
        /// Refreshes Gear list so you can select the gear you want to edit
        /// </summary>
        private void PopulateGearList()
        {
            cboGearSelector.Items.Clear();

            try
            {
                using GearContext dbContext = new GearContext();

                List<Gear> gearList = dbContext.Gears.ToList();

                foreach (Gear g in gearList)
                {
                    cboGearSelector.Items.Add(g.ItemName);
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Database is not available. PLease try again later", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
            }
        }
    }
}
