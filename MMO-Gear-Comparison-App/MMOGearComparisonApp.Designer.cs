namespace MMO_Gear_Comparison_App
{
    partial class MMOGearComparisonForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCompareGear = new Button();
            btnManageGear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnCompareGear
            // 
            btnCompareGear.Location = new Point(72, 135);
            btnCompareGear.Name = "btnCompareGear";
            btnCompareGear.Size = new Size(308, 87);
            btnCompareGear.TabIndex = 0;
            btnCompareGear.Text = "Compare Gear";
            btnCompareGear.UseVisualStyleBackColor = true;
            btnCompareGear.Click += btnCompareGear_Click;
            // 
            // btnManageGear
            // 
            btnManageGear.Location = new Point(446, 135);
            btnManageGear.Name = "btnManageGear";
            btnManageGear.Size = new Size(296, 87);
            btnManageGear.TabIndex = 1;
            btnManageGear.Text = "Manage Gear";
            btnManageGear.UseVisualStyleBackColor = true;
            btnManageGear.Click += btnManageGear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(299, 270);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(224, 53);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 386);
            Controls.Add(btnExit);
            Controls.Add(btnManageGear);
            Controls.Add(btnCompareGear);
            Name = "Form1";
            Text = "MMO-Gear-Comparison-App";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCompareGear;
        private Button btnManageGear;
        private Button btnExit;
    }
}