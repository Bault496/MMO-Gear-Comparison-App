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
            string itemName = txtGearName.Text;

            int itemLevel = Convert.ToInt32(txtGearLevel.Text);

            int? damageScaling = 0;
            if (IsTextBoxEmpty(txtDamageStat))
            {
                damageScaling = null;
            }
            else
            {
                damageScaling = Convert.ToInt32(txtDamageStat.Text);
            }

            int? armorScaling = 0;
            if (IsTextBoxEmpty(txtArmorStat))
            {
                armorScaling = null;
            }
            else
            {
                armorScaling = Convert.ToInt32(txtArmorStat.Text);
            }


            string? primaryStat = txtPrimaryStatType.Text;

            int? primaryStatScaling = 0;
            if (IsTextBoxEmpty(txtPrimaryStat))
            {
                primaryStatScaling = null;
            }
            else
            {
                primaryStatScaling = Convert.ToInt32(txtPrimaryStat.Text);
            }


            string? secondaryStat = txtSecondaryStatType.Text;

            int? secondaryStatScaling = 0;
            if (IsTextBoxEmpty(txtSecondaryStat))
            {
                secondaryStatScaling = null;
            }
            else
            {
                secondaryStatScaling = Convert.ToInt32(txtSecondaryStat.Text);
            }

            int? durability = 0;
            if (IsTextBoxEmpty(txtDurability))
            {
                durability = null;
            }
            else
            {
                durability = Convert.ToInt32(txtDurability.Text);
            }

            string gearSlot = txtGearSlot.Text;

            string? gearType = txtGearType.Text;

            Gear gear = new Gear()
            {
                ItemName = itemName,
                ItemLevel = itemLevel,
                DamageScaling = damageScaling,
                ArmorScaling = armorScaling,
                PrimaryStat = primaryStat,
                PrimaryStatScaling = primaryStatScaling,
                SecondaryStat = secondaryStat,
                SecondaryStatScaling = secondaryStatScaling,
                Durability = durability,
                GearSlot = gearSlot,
                GearType = gearType
            };

            try
            {
                using GearContext dbContext = new GearContext();

                dbContext.Gears.Add(gear);
                dbContext.SaveChanges();
                MessageBox.Show("Gear was added successfully!");
                ClearGearStats();
            }
            catch (SqlException)
            {
                MessageBox.Show("Database is not available right now. Please try again later.", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private static bool IsTextBoxEmpty(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                return true;
            }

            return false;
        }

        private void ClearGearStats()
        {
            txtGearName.Text = "";
            txtGearLevel.Text = "";
            txtDamageStat.Text = "";
            txtArmorStat.Text = "";
            txtPrimaryStatType.Text = "";
            txtPrimaryStat.Text = "";
            txtSecondaryStatType.Text = "";
            txtSecondaryStat.Text = "";
            txtDurability.Text = "";
            txtGearSlot.Text = "";
            txtGearType.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClearGear_Click(object sender, EventArgs e)
        {
            ClearGearStats();
        }
    }
}
