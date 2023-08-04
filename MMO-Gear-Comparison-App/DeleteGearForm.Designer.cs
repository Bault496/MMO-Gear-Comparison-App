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
            btnDeleteGear = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnDeleteGear
            // 
            btnDeleteGear.Location = new Point(74, 295);
            btnDeleteGear.Name = "btnDeleteGear";
            btnDeleteGear.Size = new Size(137, 60);
            btnDeleteGear.TabIndex = 0;
            btnDeleteGear.Text = "Delete Selected Gear";
            btnDeleteGear.UseVisualStyleBackColor = true;
            btnDeleteGear.Click += btnDeleteGear_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(314, 312);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 59);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel Delete Gear";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // DeleteGearForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 383);
            Controls.Add(btnCancel);
            Controls.Add(btnDeleteGear);
            Name = "DeleteGearForm";
            Text = "Delete Gear";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDeleteGear;
        private Button btnCancel;
    }
}