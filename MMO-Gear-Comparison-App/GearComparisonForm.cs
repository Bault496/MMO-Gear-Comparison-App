﻿using Microsoft.Data.SqlClient;
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
                    cboFirstGear.Items.Add(g);
                    cboSecondGear.Items.Add(g);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Database is not available. PLease try again later", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
            }
        }

        /// <summary>
        /// This will compare the two gears and compare numeric values and determine which are better.
        /// This will also highlight which of the two are greater and show the user with the use of colors or something alike
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            Gear firstGear = new Gear();
            Gear secondGear = new Gear();

            if (cboSecondGear.SelectedIndex != -1)
            {
                firstGear = (Gear)cboFirstGear.Items[cboFirstGear.SelectedIndex];
                secondGear = (Gear)cboFirstGear.Items[cboSecondGear.SelectedIndex];
                isGearBetter(firstGear, secondGear);
            }
        }

        /// <summary>
        /// When the user changes their gear selection - first gear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboFirstGear_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Checks to see if the combo boxes are unselected
            if (cboFirstGear.SelectedIndex != -1)
            {
                // Create a gear object to hold selected gear
                Gear selectedGear = new Gear();

                // Grabs the selected gear 
                selectedGear = (Gear)cboFirstGear.Items[cboFirstGear.SelectedIndex];

                // Send the gear to method PopulateFirstGearStats(Gear gear) to populate the stats in their
                // respective text boxes
                PopulateFirstGearStats(selectedGear);
            }

            // Changes any which gear is better labels to be hidden
            lblFirstGearBetter.Visible = false;
            lblSecondGearBetter.Visible = false;
            lblBothGearEqual.Visible = false;
        }

        /// <summary>
        /// When the user changes their gear selection - second gear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboSecondGear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSecondGear.SelectedIndex != -1)
            {
                // Create a gear object to hold selected gear
                Gear selectedGear = new Gear();

                // Grabs the selected gear
                selectedGear = (Gear)cboFirstGear.Items[cboSecondGear.SelectedIndex];

                // Send the gear to method PopulateFirstGearStats(Gear gear) to populate the stats in their
                // respective text boxes
                PopulateSecondGearStats(selectedGear);
            }

            // Changes any which gear is better labels to be hidden
            lblFirstGearBetter.Visible = false;
            lblSecondGearBetter.Visible = false;
            lblBothGearEqual.Visible = false;
        }

        /// <summary>
        /// This will take an object gear that will have it stats 
        /// distributed to their respective text boxes
        /// </summary>
        /// <param name="gear"></param>
        private void PopulateFirstGearStats(Gear gear)
        {
            txtGearNameFirstGear.Text = gear.ItemName;
            txtGearLevelFirstGear.Text = gear.ItemLevel.ToString();
            txtDamageStatFirstGear.Text = gear.DamageScaling.ToString();
            txtArmorStatFirstGear.Text = gear.ArmorScaling.ToString();
            txtPrimaryStatTypeFirstGear.Text = gear.PrimaryStat;
            txtPrimaryStatFirstGear.Text = gear.PrimaryStatScaling.ToString();
            txtSecondaryStatTypeFirstGear.Text = gear.SecondaryStat;
            txtSecondaryStatFirstGear.Text = gear.SecondaryStatScaling.ToString();
            txtDurabilityFirstGear.Text = gear.Durability.ToString();
            txtGearSlotFirstGear.Text = gear.GearSlot;
            txtGearTypeFirstGear.Text = gear.GearType;
        }

        /// <summary>
        /// This will take an object gear that will have it stats 
        /// distributed to their respective text boxes
        /// </summary>
        /// <param name="gear"></param>
        private void PopulateSecondGearStats(Gear gear)
        {
            txtGearNameSecondGear.Text = gear.ItemName;
            txtGearLevelSecondGear.Text = gear.ItemLevel.ToString();
            txtDamageStatSecondGear.Text = gear.DamageScaling.ToString();
            txtArmorStatSecondGear.Text = gear.ArmorScaling.ToString();
            txtPrimaryStatTypeSecondGear.Text = gear.PrimaryStat;
            txtPrimaryStatSecondGear.Text = gear.PrimaryStatScaling.ToString();
            txtSecondaryStatTypeSecondGear.Text = gear.SecondaryStat;
            txtSecondaryStatSecondGear.Text = gear.SecondaryStatScaling.ToString();
            txtDurabilitySecondGear.Text = gear.Durability.ToString();
            txtGearSlotSecondGear.Text = gear.GearSlot;
            txtGearTypeSecondGear.Text = gear.GearType;
        }

        /// <summary>
        /// This will clear the first gear stats
        /// </summary>
        private void ClearFirstGearStats()
        {
            txtGearNameFirstGear.Text = "";
            txtGearLevelFirstGear.Text = "";
            txtDamageStatFirstGear.Text = "";
            txtArmorStatFirstGear.Text = "";
            txtPrimaryStatTypeFirstGear.Text = "";
            txtPrimaryStatFirstGear.Text = "";
            txtSecondaryStatTypeFirstGear.Text = "";
            txtSecondaryStatFirstGear.Text = "";
            txtDurabilityFirstGear.Text = "";
            txtGearSlotFirstGear.Text = "";
            txtGearTypeFirstGear.Text = "";
        }

        /// <summary>
        /// This will clear the second gear stats
        /// </summary>
        private void ClearSecondGearStats()
        {
            txtGearNameSecondGear.Text = "";
            txtGearLevelSecondGear.Text = "";
            txtDamageStatSecondGear.Text = "";
            txtArmorStatSecondGear.Text = "";
            txtPrimaryStatTypeSecondGear.Text = "";
            txtPrimaryStatSecondGear.Text = "";
            txtSecondaryStatTypeSecondGear.Text = "";
            txtSecondaryStatSecondGear.Text = "";
            txtDurabilitySecondGear.Text = "";
            txtGearSlotSecondGear.Text = "";
            txtGearTypeSecondGear.Text = "";
        }

        /// <summary>
        /// This will cause one of two labels to appear signaling 
        /// which gear is better based on gear level
        /// </summary>
        private void isGearBetter(Gear firstGear, Gear secondGear)
        {
            if (firstGear.ItemLevel > secondGear.ItemLevel)
            {
                lblFirstGearBetter.Visible = true;
            }
            else if (secondGear.ItemLevel > firstGear.ItemLevel)
            {
                lblSecondGearBetter.Visible = true;
            }
            else
            {
                 lblBothGearEqual.Visible = true;
            }
        }

        private void btnExitGearComparison_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Clear all text boxes of their values and clear the selected item in the
        /// combo boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearSelectedGear_Click(object sender, EventArgs e)
        {
            cboFirstGear.SelectedIndex = -1;
            ClearFirstGearStats();
            cboSecondGear.SelectedIndex = -1;
            ClearSecondGearStats();

            lblFirstGearBetter.Visible = false;
            lblSecondGearBetter.Visible = false;
            lblBothGearEqual.Visible = false;
        }
    }
}
