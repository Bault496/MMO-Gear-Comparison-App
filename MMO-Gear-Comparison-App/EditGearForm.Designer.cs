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
            // 
            // EditGearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboGearSelector);
            this.Controls.Add(this.btnEditGear);
            this.Controls.Add(this.btnCancel);
            this.Name = "EditGearForm";
            this.Text = "Edit Gear";
            this.Load += new System.EventHandler(this.EditGearForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCancel;
        private Button btnEditGear;
        private ComboBox cboGearSelector;
    }
}