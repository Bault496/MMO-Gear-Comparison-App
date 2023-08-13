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
    public partial class CreateGearForm : Form
    {
        public CreateGearForm()
        {
            InitializeComponent();
        }

        private void btnSubmitGear_Click(object sender, EventArgs e)
        {
            AddGear();
        }

        private void AddGear()
        {
            Gear gear = new Gear()
            {
                ItemName = txtGearName.Text,
                ItemLevel = Convert.ToInt32(txtGearLevel.Text),
                DamageScaling = Convert.ToInt32(txtDamageStat.Text),
                ArmorScaling = Convert.ToInt32(txtArmorStat.Text),
                primaryStat = txtPrimaryStatType.Text,
                primaryStatScaling = Convert.ToInt32(txtPrimaryStat),
                secondaryStat = txtSecondaryStatType.Text,
                secondaryStatScaling = Convert.ToInt32(txtSecondaryStat.Text),
                Durability = Convert.ToInt32(txtDurability.Text),
                GearSlot = txtGearSlot.Text,
                GearType = txtGearType.Text
            };

            try
            {
                using GearContext dbContext = new GearContext();

                dbContext.Gears.Add(gear);
                dbContext.SaveChanges();
            }
            catch (SqlException)
            {
                MessageBox.Show("Database is not available right now. Please try again later.", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
