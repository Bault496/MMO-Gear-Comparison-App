namespace MMO_Gear_Comparison_App
{
    partial class EditGearForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditGear = new System.Windows.Forms.Button();
            this.cboGearSelector = new System.Windows.Forms.ComboBox();
            this.txtGearType = new System.Windows.Forms.TextBox();
            this.txtGearSlot = new System.Windows.Forms.TextBox();
            this.txtDurability = new System.Windows.Forms.TextBox();
            this.txtSecondaryStat = new System.Windows.Forms.TextBox();
            this.txtSecondaryStatType = new System.Windows.Forms.TextBox();
            this.lblGearType = new System.Windows.Forms.Label();
            this.lblGearSlot = new System.Windows.Forms.Label();
            this.lblDurability = new System.Windows.Forms.Label();
            this.lblSecondaryStat = new System.Windows.Forms.Label();
            this.lblSecondaryStatType = new System.Windows.Forms.Label();
            this.lblPrimaryStat = new System.Windows.Forms.Label();
            this.lblPrimaryStatType = new System.Windows.Forms.Label();
            this.lblArmorStat = new System.Windows.Forms.Label();
            this.lblDamageStat = new System.Windows.Forms.Label();
            this.lblGearLevel = new System.Windows.Forms.Label();
            this.txtPrimaryStat = new System.Windows.Forms.TextBox();
            this.txtPrimaryStatType = new System.Windows.Forms.TextBox();
            this.txtArmorStat = new System.Windows.Forms.TextBox();
            this.txtDamageStat = new System.Windows.Forms.TextBox();
            this.txtGearLevel = new System.Windows.Forms.TextBox();
            this.txtGearName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(658, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 72);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel Edit Gear";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnEditGear
            // 
            this.btnEditGear.Location = new System.Drawing.Point(140, 344);
            this.btnEditGear.Name = "btnEditGear";
            this.btnEditGear.Size = new System.Drawing.Size(158, 74);
            this.btnEditGear.TabIndex = 1;
            this.btnEditGear.Text = "Edit Selected Gear";
            this.btnEditGear.UseVisualStyleBackColor = true;
            // 
            // cboGearSelector
            // 
            this.cboGearSelector.FormattingEnabled = true;
            this.cboGearSelector.Location = new System.Drawing.Point(252, 30);
            this.cboGearSelector.Name = "cboGearSelector";
            this.cboGearSelector.Size = new System.Drawing.Size(159, 23);
            this.cboGearSelector.TabIndex = 2;
            this.cboGearSelector.SelectedIndexChanged += new System.EventHandler(this.cboGearSelector_SelectedIndexChanged);
            // 
            // txtGearType
            // 
            this.txtGearType.Location = new System.Drawing.Point(479, 252);
            this.txtGearType.Name = "txtGearType";
            this.txtGearType.Size = new System.Drawing.Size(100, 23);
            this.txtGearType.TabIndex = 46;
            // 
            // txtGearSlot
            // 
            this.txtGearSlot.Location = new System.Drawing.Point(479, 204);
            this.txtGearSlot.Name = "txtGearSlot";
            this.txtGearSlot.Size = new System.Drawing.Size(100, 23);
            this.txtGearSlot.TabIndex = 45;
            // 
            // txtDurability
            // 
            this.txtDurability.Location = new System.Drawing.Point(479, 158);
            this.txtDurability.Name = "txtDurability";
            this.txtDurability.Size = new System.Drawing.Size(100, 23);
            this.txtDurability.TabIndex = 44;
            // 
            // txtSecondaryStat
            // 
            this.txtSecondaryStat.Location = new System.Drawing.Point(479, 115);
            this.txtSecondaryStat.Name = "txtSecondaryStat";
            this.txtSecondaryStat.Size = new System.Drawing.Size(100, 23);
            this.txtSecondaryStat.TabIndex = 43;
            // 
            // txtSecondaryStatType
            // 
            this.txtSecondaryStatType.Location = new System.Drawing.Point(479, 76);
            this.txtSecondaryStatType.Name = "txtSecondaryStatType";
            this.txtSecondaryStatType.Size = new System.Drawing.Size(100, 23);
            this.txtSecondaryStatType.TabIndex = 42;
            // 
            // lblGearType
            // 
            this.lblGearType.AutoSize = true;
            this.lblGearType.Location = new System.Drawing.Point(403, 255);
            this.lblGearType.Name = "lblGearType";
            this.lblGearType.Size = new System.Drawing.Size(61, 15);
            this.lblGearType.TabIndex = 41;
            this.lblGearType.Text = "Gear Type:";
            // 
            // lblGearSlot
            // 
            this.lblGearSlot.AutoSize = true;
            this.lblGearSlot.Location = new System.Drawing.Point(407, 207);
            this.lblGearSlot.Name = "lblGearSlot";
            this.lblGearSlot.Size = new System.Drawing.Size(57, 15);
            this.lblGearSlot.TabIndex = 40;
            this.lblGearSlot.Text = "Gear Slot:";
            // 
            // lblDurability
            // 
            this.lblDurability.AutoSize = true;
            this.lblDurability.Location = new System.Drawing.Point(403, 161);
            this.lblDurability.Name = "lblDurability";
            this.lblDurability.Size = new System.Drawing.Size(61, 15);
            this.lblDurability.TabIndex = 39;
            this.lblDurability.Text = "Durability:";
            // 
            // lblSecondaryStat
            // 
            this.lblSecondaryStat.AutoSize = true;
            this.lblSecondaryStat.Location = new System.Drawing.Point(376, 118);
            this.lblSecondaryStat.Name = "lblSecondaryStat";
            this.lblSecondaryStat.Size = new System.Drawing.Size(88, 15);
            this.lblSecondaryStat.TabIndex = 38;
            this.lblSecondaryStat.Text = "Secondary Stat:";
            // 
            // lblSecondaryStatType
            // 
            this.lblSecondaryStatType.AutoSize = true;
            this.lblSecondaryStatType.Location = new System.Drawing.Point(349, 79);
            this.lblSecondaryStatType.Name = "lblSecondaryStatType";
            this.lblSecondaryStatType.Size = new System.Drawing.Size(115, 15);
            this.lblSecondaryStatType.TabIndex = 37;
            this.lblSecondaryStatType.Text = "Secondary Stat Type:";
            // 
            // lblPrimaryStat
            // 
            this.lblPrimaryStat.AutoSize = true;
            this.lblPrimaryStat.Location = new System.Drawing.Point(121, 298);
            this.lblPrimaryStat.Name = "lblPrimaryStat";
            this.lblPrimaryStat.Size = new System.Drawing.Size(74, 15);
            this.lblPrimaryStat.TabIndex = 36;
            this.lblPrimaryStat.Text = "Primary Stat:";
            // 
            // lblPrimaryStatType
            // 
            this.lblPrimaryStatType.AutoSize = true;
            this.lblPrimaryStatType.Location = new System.Drawing.Point(94, 255);
            this.lblPrimaryStatType.Name = "lblPrimaryStatType";
            this.lblPrimaryStatType.Size = new System.Drawing.Size(101, 15);
            this.lblPrimaryStatType.TabIndex = 35;
            this.lblPrimaryStatType.Text = "Primary Stat Type:";
            // 
            // lblArmorStat
            // 
            this.lblArmorStat.AutoSize = true;
            this.lblArmorStat.Location = new System.Drawing.Point(128, 207);
            this.lblArmorStat.Name = "lblArmorStat";
            this.lblArmorStat.Size = new System.Drawing.Size(67, 15);
            this.lblArmorStat.TabIndex = 34;
            this.lblArmorStat.Text = "Armor Stat:";
            // 
            // lblDamageStat
            // 
            this.lblDamageStat.AutoSize = true;
            this.lblDamageStat.Location = new System.Drawing.Point(118, 161);
            this.lblDamageStat.Name = "lblDamageStat";
            this.lblDamageStat.Size = new System.Drawing.Size(77, 15);
            this.lblDamageStat.TabIndex = 33;
            this.lblDamageStat.Text = "Damage Stat:";
            // 
            // lblGearLevel
            // 
            this.lblGearLevel.AutoSize = true;
            this.lblGearLevel.Location = new System.Drawing.Point(131, 118);
            this.lblGearLevel.Name = "lblGearLevel";
            this.lblGearLevel.Size = new System.Drawing.Size(64, 15);
            this.lblGearLevel.TabIndex = 32;
            this.lblGearLevel.Text = "Gear Level:";
            // 
            // txtPrimaryStat
            // 
            this.txtPrimaryStat.Location = new System.Drawing.Point(222, 295);
            this.txtPrimaryStat.Name = "txtPrimaryStat";
            this.txtPrimaryStat.Size = new System.Drawing.Size(100, 23);
            this.txtPrimaryStat.TabIndex = 31;
            // 
            // txtPrimaryStatType
            // 
            this.txtPrimaryStatType.Location = new System.Drawing.Point(222, 252);
            this.txtPrimaryStatType.Name = "txtPrimaryStatType";
            this.txtPrimaryStatType.Size = new System.Drawing.Size(100, 23);
            this.txtPrimaryStatType.TabIndex = 30;
            // 
            // txtArmorStat
            // 
            this.txtArmorStat.Location = new System.Drawing.Point(222, 204);
            this.txtArmorStat.Name = "txtArmorStat";
            this.txtArmorStat.Size = new System.Drawing.Size(100, 23);
            this.txtArmorStat.TabIndex = 29;
            // 
            // txtDamageStat
            // 
            this.txtDamageStat.Location = new System.Drawing.Point(222, 158);
            this.txtDamageStat.Name = "txtDamageStat";
            this.txtDamageStat.Size = new System.Drawing.Size(100, 23);
            this.txtDamageStat.TabIndex = 28;
            // 
            // txtGearLevel
            // 
            this.txtGearLevel.Location = new System.Drawing.Point(222, 115);
            this.txtGearLevel.Name = "txtGearLevel";
            this.txtGearLevel.Size = new System.Drawing.Size(100, 23);
            this.txtGearLevel.TabIndex = 27;
            // 
            // txtGearName
            // 
            this.txtGearName.Location = new System.Drawing.Point(222, 76);
            this.txtGearName.Name = "txtGearName";
            this.txtGearName.Size = new System.Drawing.Size(100, 23);
            this.txtGearName.TabIndex = 26;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(126, 79);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(69, 15);
            this.lblItemName.TabIndex = 25;
            this.lblItemName.Text = "Gear Name:";
            // 
            // EditGearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGearType);
            this.Controls.Add(this.txtGearSlot);
            this.Controls.Add(this.txtDurability);
            this.Controls.Add(this.txtSecondaryStat);
            this.Controls.Add(this.txtSecondaryStatType);
            this.Controls.Add(this.lblGearType);
            this.Controls.Add(this.lblGearSlot);
            this.Controls.Add(this.lblDurability);
            this.Controls.Add(this.lblSecondaryStat);
            this.Controls.Add(this.lblSecondaryStatType);
            this.Controls.Add(this.lblPrimaryStat);
            this.Controls.Add(this.lblPrimaryStatType);
            this.Controls.Add(this.lblArmorStat);
            this.Controls.Add(this.lblDamageStat);
            this.Controls.Add(this.lblGearLevel);
            this.Controls.Add(this.txtPrimaryStat);
            this.Controls.Add(this.txtPrimaryStatType);
            this.Controls.Add(this.txtArmorStat);
            this.Controls.Add(this.txtDamageStat);
            this.Controls.Add(this.txtGearLevel);
            this.Controls.Add(this.txtGearName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.cboGearSelector);
            this.Controls.Add(this.btnEditGear);
            this.Controls.Add(this.btnCancel);
            this.Name = "EditGearForm";
            this.Text = "Edit Gear";
            this.Load += new System.EventHandler(this.EditGearForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnEditGear;
        private ComboBox cboGearSelector;
        private TextBox txtGearType;
        private TextBox txtGearSlot;
        private TextBox txtDurability;
        private TextBox txtSecondaryStat;
        private TextBox txtSecondaryStatType;
        private Label lblGearType;
        private Label lblGearSlot;
        private Label lblDurability;
        private Label lblSecondaryStat;
        private Label lblSecondaryStatType;
        private Label lblPrimaryStat;
        private Label lblPrimaryStatType;
        private Label lblArmorStat;
        private Label lblDamageStat;
        private Label lblGearLevel;
        private TextBox txtPrimaryStat;
        private TextBox txtPrimaryStatType;
        private TextBox txtArmorStat;
        private TextBox txtDamageStat;
        private TextBox txtGearLevel;
        private TextBox txtGearName;
        private Label lblItemName;
    }
}