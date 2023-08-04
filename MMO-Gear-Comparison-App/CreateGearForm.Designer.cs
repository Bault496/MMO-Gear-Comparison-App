namespace MMO_Gear_Comparison_App
{
    partial class CreateGearForm
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
            btnSubmitGear = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnSubmitGear
            // 
            btnSubmitGear.Location = new Point(158, 347);
            btnSubmitGear.Name = "btnSubmitGear";
            btnSubmitGear.Size = new Size(164, 72);
            btnSubmitGear.TabIndex = 0;
            btnSubmitGear.Text = "Submit Created Gear";
            btnSubmitGear.UseVisualStyleBackColor = true;
            btnSubmitGear.Click += btnSubmitGear_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(633, 366);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(155, 72);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel Create Gear";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateGearForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmitGear);
            Name = "CreateGearForm";
            Text = "Create Gear";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSubmitGear;
        private Button btnCancel;
    }
}