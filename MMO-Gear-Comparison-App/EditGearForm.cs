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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

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

        private void cboGearSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

            Gear selectedGear = (Gear)cboGearSelector.SelectedItem;
            if (cboGearSelector.SelectedIndex != -1)
            {
                RefreshStats(selectedGear);
            }
            else
            {
                ClearStat();
            }
        }

        private void ClearStat()
        {
            txtGearName.Text = "";
            txtArmorStat.Text = "";
            txtDamageStat.Text = "";
            txtDurability.Text = "";
            txtGearLevel.Text = "";
            txtPrimaryStatType.Text = "";
            txtSecondaryStatType.Text = "";
            txtPrimaryStat.Text = "";
            txtSecondaryStat.Text = "";
            txtGearSlot.Text = "";
            txtGearType.Text = "";
        }

        private void RefreshStats(Gear selectedgear)
        {


            txtGearName.Text = selectedgear.ItemName;
            txtArmorStat.Text = selectedgear.ArmorScaling.ToString();
            txtDamageStat.Text = selectedgear.DamageScaling.ToString();
            txtDurability.Text = selectedgear.Durability.ToString();
            txtGearLevel.Text = selectedgear.ItemLevel.ToString();
            txtPrimaryStatType.Text = selectedgear.PrimaryStat;
            txtSecondaryStatType.Text = selectedgear.SecondaryStat;
            txtPrimaryStat.Text = selectedgear.PrimaryStatScaling.ToString();
            txtSecondaryStat.Text = selectedgear.SecondaryStatScaling.ToString();
            txtGearSlot.Text = selectedgear.GearSlot;
            txtGearType.Text = selectedgear.GearType;
            
            


        }

        private void UpdateGear()
        {
            Gear selectedGear = (Gear)cboGearSelector.SelectedItem;
            int itemId = selectedGear.ItemID;
            bool isAllValid = IsInputValid();
            if (isAllValid)
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
                    ItemID = itemId,
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

                    dbContext.Gears.Update(gear);
                    dbContext.SaveChanges();
                    MessageBox.Show("Gear was updated successfully!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Database is not available right now. Please try again later.", "Database Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                cboGearSelector.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Checks all inputs to verify they have the right info
        /// displays errormessages if not
        /// </summary>
        /// <returns></returns>
        private bool IsInputValid()
        {
            bool isAllValid = true;
            string errMessages = "";
            int result;

            //check each check box for valid numbers
            if (!int.TryParse(txtGearLevel.Text, out result))
            {
                errMessages += "Gear Level needs a valid number. \n";
                isAllValid = false;
            }

            if (IsTextBoxEmpty(txtGearName))
            {
                errMessages += "Gear Name needs a name. \n";
                isAllValid = false;
            }

            if (IsTextBoxEmpty(txtGearType))
            {
                errMessages += "Gear Type needs to be defined. \n";
                isAllValid = false;
            }

            if (IsTextBoxEmpty(txtGearSlot))
            {
                errMessages += "Gear Slot needs to be specified. \n";
                isAllValid = false;
            }

            if (IsTextBoxEmpty(txtDamageStat))
            {

            }
            else
            {
                if (!int.TryParse(txtDamageStat.Text, out result))
                {
                    errMessages += "Damage Stat needs a valid number. \n";
                    isAllValid = false;
                }
            }

            if (IsTextBoxEmpty(txtArmorStat))
            {

            }
            else
            {
                if (!int.TryParse(txtArmorStat.Text, out result))
                {
                    errMessages += "Armor Stat needs a valid number. \n";
                    isAllValid = false;
                }
            }

            if (IsTextBoxEmpty(txtPrimaryStat))
            {

            }
            else
            {
                if (!int.TryParse(txtPrimaryStat.Text, out result))
                {
                    errMessages += "Primary Stat needs a valid number. \n";
                    isAllValid = false;
                }
            }

            if (IsTextBoxEmpty(txtSecondaryStat))
            {

            }
            else
            {
                if (!int.TryParse(txtSecondaryStat.Text, out result))
                {
                    errMessages += "Secondary Stat needs a valid number. \n";
                    isAllValid = false;
                }
            }

            if (IsTextBoxEmpty(txtDurability))
            {

            }
            else
            {
                if (!int.TryParse(txtDurability.Text, out result))
                {
                    errMessages += "Durability Stat needs a valid number. \n";
                    isAllValid = false;
                }
            }

            if (IsTextBoxEmpty(txtSecondaryStatType) && IsNotTextBoxEmpty(txtSecondaryStat))
            {

                errMessages += "Secondary Stat Type needs to be defined before adding a value. \n";
                isAllValid = false;
            }
            if (IsNotTextBoxEmpty(txtSecondaryStatType) && IsTextBoxEmpty(txtSecondaryStat))
            {
                errMessages += "Secondary Stat needs to have valid number. \n";
                isAllValid = false;
            }

            if (IsTextBoxEmpty(txtPrimaryStatType) && IsNotTextBoxEmpty(txtPrimaryStat))
            {

                errMessages += "Primary Stat Type needs to be defined before adding a value. \n";
                isAllValid = false;
            }
            if (IsNotTextBoxEmpty(txtPrimaryStatType) && IsTextBoxEmpty(txtPrimaryStat))
            {
                errMessages += "Primary Stat needs to have valid number. \n";
                isAllValid = false;
            }





            //displays error messaages
            if (isAllValid == false)
            {
                MessageBox.Show(errMessages);
                return false;
            }
            return true;

        }

        private bool IsNotTextBoxEmpty(TextBox txtBox)
        {
            if (string.IsNullOrWhiteSpace(txtBox.Text))
            {
                return false;
            }

            return true;
        }

        private static bool IsTextBoxEmpty(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                return true;
            }

            return false;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditGear_Click_1(object sender, EventArgs e)
        {
            UpdateGear();
            PopulateGearList();
        }
    }
}
