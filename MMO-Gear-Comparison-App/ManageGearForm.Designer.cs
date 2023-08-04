namespace MMO_Gear_Comparison_App
{
    partial class ManageGearForm
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
            btnCreateGear = new Button();
            btnEditGear = new Button();
            btnDeleteGear = new Button();
            btnExitManageGear = new Button();
            SuspendLayout();
            // 
            // btnCreateGear
            // 
            btnCreateGear.Location = new Point(12, 55);
            btnCreateGear.Name = "btnCreateGear";
            btnCreateGear.Size = new Size(195, 64);
            btnCreateGear.TabIndex = 0;
            btnCreateGear.Text = "Create Gear";
            btnCreateGear.UseVisualStyleBackColor = true;
            btnCreateGear.Click += btnCreateGear_Click;
            // 
            // btnEditGear
            // 
            btnEditGear.Location = new Point(305, 55);
            btnEditGear.Name = "btnEditGear";
            btnEditGear.Size = new Size(193, 64);
            btnEditGear.TabIndex = 1;
            btnEditGear.Text = "Edit Gear";
            btnEditGear.UseVisualStyleBackColor = true;
            btnEditGear.Click += btnEditGear_Click;
            // 
            // btnDeleteGear
            // 
            btnDeleteGear.Location = new Point(572, 55);
            btnDeleteGear.Name = "btnDeleteGear";
            btnDeleteGear.Size = new Size(193, 64);
            btnDeleteGear.TabIndex = 2;
            btnDeleteGear.Text = "Delete Gear";
            btnDeleteGear.UseVisualStyleBackColor = true;
            btnDeleteGear.Click += btnDeleteGear_Click;
            // 
            // btnExitManageGear
            // 
            btnExitManageGear.Location = new Point(305, 171);
            btnExitManageGear.Name = "btnExitManageGear";
            btnExitManageGear.Size = new Size(193, 65);
            btnExitManageGear.TabIndex = 3;
            btnExitManageGear.Text = "Exit Manage Gear";
            btnExitManageGear.UseVisualStyleBackColor = true;
            btnExitManageGear.Click += btnExitManageGear_Click;
            // 
            // ManageGear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 248);
            Controls.Add(btnExitManageGear);
            Controls.Add(btnDeleteGear);
            Controls.Add(btnEditGear);
            Controls.Add(btnCreateGear);
            Name = "ManageGear";
            Text = "ManageGear";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateGear;
        private Button btnEditGear;
        private Button btnDeleteGear;
        private Button btnExitManageGear;
    }
}