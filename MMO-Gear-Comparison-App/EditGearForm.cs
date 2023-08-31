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
    }
}
