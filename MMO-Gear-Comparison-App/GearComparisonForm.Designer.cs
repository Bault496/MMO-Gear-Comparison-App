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
            // GearComparisonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExitGearComparison);
            Name = "GearComparisonForm";
            Text = "GearComparison";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExitGearComparison;
    }
}