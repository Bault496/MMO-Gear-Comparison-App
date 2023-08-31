namespace MMO_Gear_Comparison_App
{
    partial class DeleteGearForm
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
            this.btnDeleteGear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.GearToDelete = new System.Windows.Forms.Label();
            this.cboGearSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDeleteGear
            // 
            this.btnDeleteGear.Location = new System.Drawing.Point(74, 295);
            this.btnDeleteGear.Name = "btnDeleteGear";
            this.btnDeleteGear.Size = new System.Drawing.Size(137, 60);
            this.btnDeleteGear.TabIndex = 0;
            this.btnDeleteGear.Text = "Delete Selected Gear";
            this.btnDeleteGear.UseVisualStyleBackColor = true;
            this.btnDeleteGear.Click += new System.EventHandler(this.btnDeleteGear_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(314, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 59);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel Delete Gear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // GearToDelete
            // 
            this.GearToDelete.AutoSize = true;
            this.GearToDelete.Location = new System.Drawing.Point(59, 47);
            this.GearToDelete.Name = "GearToDelete";
            this.GearToDelete.Size = new System.Drawing.Size(87, 15);
            this.GearToDelete.TabIndex = 2;
            this.GearToDelete.Text = "Gear to Delete :";
            // 
            // cboGearSelector
            // 
            this.cboGearSelector.FormattingEnabled = true;
            this.cboGearSelector.Location = new System.Drawing.Point(152, 44);
            this.cboGearSelector.Name = "cboGearSelector";
            this.cboGearSelector.Size = new System.Drawing.Size(121, 23);
            this.cboGearSelector.TabIndex = 3;
            // 
            // DeleteGearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 383);
            this.Controls.Add(this.cboGearSelector);
            this.Controls.Add(this.GearToDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteGear);
            this.Name = "DeleteGearForm";
            this.Text = "Delete Gear";
            this.Load += new System.EventHandler(this.DeleteGearForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDeleteGear;
        private Button btnCancel;
        private Label GearToDelete;
        private ComboBox cboGearSelector;
    }
}