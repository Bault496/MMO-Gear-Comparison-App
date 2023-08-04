namespace MMO_Gear_Comparison_App
{
    partial class GearComparisonForm
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
            btnExitGearComparison = new Button();
            cboFirstGear = new ComboBox();
            cboSecondGear = new ComboBox();
            lblGearOne = new Label();
            lblGearSecond = new Label();
            SuspendLayout();
            // 
            // btnExitGearComparison
            // 
            btnExitGearComparison.Location = new Point(304, 349);
            btnExitGearComparison.Name = "btnExitGearComparison";
            btnExitGearComparison.Size = new Size(202, 66);
            btnExitGearComparison.TabIndex = 0;
            btnExitGearComparison.Text = "Exit Gear Comparison";
            btnExitGearComparison.UseVisualStyleBackColor = true;
            btnExitGearComparison.Click += btnExitGearComparison_Click;
            // 
            // cboFirstGear
            // 
            cboFirstGear.FormattingEnabled = true;
            cboFirstGear.Location = new Point(64, 55);
            cboFirstGear.Name = "cboFirstGear";
            cboFirstGear.Size = new Size(121, 23);
            cboFirstGear.TabIndex = 1;
            // 
            // cboSecondGear
            // 
            cboSecondGear.FormattingEnabled = true;
            cboSecondGear.Location = new Point(615, 55);
            cboSecondGear.Name = "cboSecondGear";
            cboSecondGear.Size = new Size(121, 23);
            cboSecondGear.TabIndex = 2;
            // 
            // lblGearOne
            // 
            lblGearOne.AutoSize = true;
            lblGearOne.Location = new Point(64, 23);
            lblGearOne.Name = "lblGearOne";
            lblGearOne.Size = new Size(56, 15);
            lblGearOne.TabIndex = 3;
            lblGearOne.Text = "First Gear";
            // 
            // lblGearSecond
            // 
            lblGearSecond.AutoSize = true;
            lblGearSecond.Location = new Point(615, 23);
            lblGearSecond.Name = "lblGearSecond";
            lblGearSecond.Size = new Size(73, 15);
            lblGearSecond.TabIndex = 4;
            lblGearSecond.Text = "Second Gear";
            // 
            // GearComparisonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGearSecond);
            Controls.Add(lblGearOne);
            Controls.Add(cboSecondGear);
            Controls.Add(cboFirstGear);
            Controls.Add(btnExitGearComparison);
            Name = "GearComparisonForm";
            Text = "GearComparison";
            Load += GearComparisonForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExitGearComparison;
        private ComboBox cboFirstGear;
        private ComboBox cboSecondGear;
        private Label lblGearOne;
        private Label lblGearSecond;
    }
}