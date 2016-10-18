namespace Dev020101.Controls.ProjectsControls
{
    partial class EditProjectsControl
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
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.SaveButtom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.budgetTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buildingcomboBox = new System.Windows.Forms.ComboBox();
            this.addresscomboBox = new System.Windows.Forms.ComboBox();
            this.allocatedHourstextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(43, 580);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(0, 17);
            this.feedbackLabel.TabIndex = 36;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(46, 678);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Name";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(46, 67);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(150, 22);
            this.nameTextbox.TabIndex = 1;
            // 
            // SaveButtom
            // 
            this.SaveButtom.Location = new System.Drawing.Point(46, 621);
            this.SaveButtom.Name = "SaveButtom";
            this.SaveButtom.Size = new System.Drawing.Size(150, 23);
            this.SaveButtom.TabIndex = 6;
            this.SaveButtom.Text = "Save";
            this.SaveButtom.UseVisualStyleBackColor = true;
            this.SaveButtom.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Budget";
            // 
            // budgetTextbox
            // 
            this.budgetTextbox.Location = new System.Drawing.Point(46, 149);
            this.budgetTextbox.Name = "budgetTextbox";
            this.budgetTextbox.Size = new System.Drawing.Size(150, 22);
            this.budgetTextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Allocated hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Building";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Address";
            // 
            // buildingcomboBox
            // 
            this.buildingcomboBox.FormattingEnabled = true;
            this.buildingcomboBox.Location = new System.Drawing.Point(46, 315);
            this.buildingcomboBox.Name = "buildingcomboBox";
            this.buildingcomboBox.Size = new System.Drawing.Size(147, 24);
            this.buildingcomboBox.TabIndex = 4;
            // 
            // addresscomboBox
            // 
            this.addresscomboBox.FormattingEnabled = true;
            this.addresscomboBox.Location = new System.Drawing.Point(46, 402);
            this.addresscomboBox.Name = "addresscomboBox";
            this.addresscomboBox.Size = new System.Drawing.Size(331, 24);
            this.addresscomboBox.TabIndex = 5;
            // 
            // allocatedHourstextBox
            // 
            this.allocatedHourstextBox.Location = new System.Drawing.Point(49, 240);
            this.allocatedHourstextBox.Name = "allocatedHourstextBox";
            this.allocatedHourstextBox.Size = new System.Drawing.Size(150, 22);
            this.allocatedHourstextBox.TabIndex = 3;
            // 
            // EditProjectsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.allocatedHourstextBox);
            this.Controls.Add(this.addresscomboBox);
            this.Controls.Add(this.buildingcomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.budgetTextbox);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.SaveButtom);
            this.Name = "EditProjectsControl";
            this.Size = new System.Drawing.Size(1262, 743);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Button SaveButtom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox budgetTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox buildingcomboBox;
        private System.Windows.Forms.ComboBox addresscomboBox;
        private System.Windows.Forms.TextBox allocatedHourstextBox;
    }
}
