using Microsoft.Data.SqlClient;
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
    public partial class DeleteGearForm : Form
    {
        public DeleteGearForm()
        {
            InitializeComponent();
        }

        private void btnDeleteGear_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteGearForm_Load(object sender, EventArgs e)
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
                    cboGearSelector.Items.Add(g);

                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Database is not available. PLease try again later", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
            }
        }

        private void DeleteGear()
        {
            Gear selectedGear = (Gear)cboGearSelector.SelectedItem;
            int itemId = selectedGear.ItemID;
            

            try
            {
                using GearContext dbContext = new GearContext();

                dbContext.Gears.Remove(selectedGear);
                dbContext.SaveChanges();
            }
            catch (SqlException)
            {
                MessageBox.Show("Database is not available right now. Please try again later.", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            cboGearSelector.SelectedIndex = -1;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteGear_Click_1(object sender, EventArgs e)
        {
            DeleteGear();
            PopulateGearList();
        }
    }
}
