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
            btnCancel = new Button();
            btnEditGear = new Button();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(658, 366);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 72);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel Edit Gear";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEditGear
            // 
            btnEditGear.Location = new Point(140, 344);
            btnEditGear.Name = "btnEditGear";
            btnEditGear.Size = new Size(158, 74);
            btnEditGear.TabIndex = 1;
            btnEditGear.Text = "Edit Selected Gear";
            btnEditGear.UseVisualStyleBackColor = true;
            btnEditGear.Click += btnEditGear_Click;
            // 
            // EditGearForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditGear);
            Controls.Add(btnCancel);
            Name = "EditGearForm";
            Text = "Edit Gear";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private Button btnEditGear;
    }
}