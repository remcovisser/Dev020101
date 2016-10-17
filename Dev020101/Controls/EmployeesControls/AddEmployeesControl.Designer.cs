namespace Dev020101.Controls.EmployeesControls
{
    partial class AddEmployeesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.bsnTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastnameTextbox = new System.Windows.Forms.TextBox();
            this.firstnameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButtom = new System.Windows.Forms.Button();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.headquartersComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "BSN";
            // 
            // bsnTextbox
            // 
            this.bsnTextbox.Location = new System.Drawing.Point(110, 65);
            this.bsnTextbox.Name = "bsnTextbox";
            this.bsnTextbox.Size = new System.Drawing.Size(150, 22);
            this.bsnTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lastname";
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox.Location = new System.Drawing.Point(110, 242);
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.Size = new System.Drawing.Size(150, 22);
            this.lastnameTextbox.TabIndex = 3;
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.Location = new System.Drawing.Point(110, 152);
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.Size = new System.Drawing.Size(150, 22);
            this.firstnameTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Firstname";
            // 
            // SaveButtom
            // 
            this.SaveButtom.Location = new System.Drawing.Point(110, 629);
            this.SaveButtom.Name = "SaveButtom";
            this.SaveButtom.Size = new System.Drawing.Size(150, 23);
            this.SaveButtom.TabIndex = 5;
            this.SaveButtom.Text = "Save";
            this.SaveButtom.UseVisualStyleBackColor = true;
            this.SaveButtom.Click += new System.EventHandler(this.SaveButtom_Click);
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(107, 586);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(0, 17);
            this.feedbackLabel.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Headquarters";
            // 
            // headquartersComboBox
            // 
            this.headquartersComboBox.FormattingEnabled = true;
            this.headquartersComboBox.Location = new System.Drawing.Point(110, 347);
            this.headquartersComboBox.Name = "headquartersComboBox";
            this.headquartersComboBox.Size = new System.Drawing.Size(150, 24);
            this.headquartersComboBox.TabIndex = 4;
            // 
            // AddEmployeesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.headquartersComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bsnTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastnameTextbox);
            this.Controls.Add(this.firstnameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButtom);
            this.Name = "AddEmployeesControl";
            this.Size = new System.Drawing.Size(1262, 743);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bsnTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastnameTextbox;
        private System.Windows.Forms.TextBox firstnameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButtom;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox headquartersComboBox;
    }
}
