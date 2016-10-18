namespace Dev020101.Controls.ProjectsControls
{
    partial class AddProjectsControl
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
            this.addresscomboBox = new System.Windows.Forms.ComboBox();
            this.buildingcomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.budgetTextbox = new System.Windows.Forms.TextBox();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.SaveButtom = new System.Windows.Forms.Button();
            this.allocatedHourstextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addresscomboBox
            // 
            this.addresscomboBox.FormattingEnabled = true;
            this.addresscomboBox.Location = new System.Drawing.Point(46, 388);
            this.addresscomboBox.Name = "addresscomboBox";
            this.addresscomboBox.Size = new System.Drawing.Size(405, 24);
            this.addresscomboBox.TabIndex = 5;
            // 
            // buildingcomboBox
            // 
            this.buildingcomboBox.FormattingEnabled = true;
            this.buildingcomboBox.Location = new System.Drawing.Point(46, 301);
            this.buildingcomboBox.Name = "buildingcomboBox";
            this.buildingcomboBox.Size = new System.Drawing.Size(147, 24);
            this.buildingcomboBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Building";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Allocated hours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Budget";
            // 
            // budgetTextbox
            // 
            this.budgetTextbox.Location = new System.Drawing.Point(46, 135);
            this.budgetTextbox.Name = "budgetTextbox";
            this.budgetTextbox.Size = new System.Drawing.Size(150, 22);
            this.budgetTextbox.TabIndex = 2;
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(43, 566);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(0, 17);
            this.feedbackLabel.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Name";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(46, 53);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(150, 22);
            this.nameTextbox.TabIndex = 1;
            // 
            // SaveButtom
            // 
            this.SaveButtom.Location = new System.Drawing.Point(46, 607);
            this.SaveButtom.Name = "SaveButtom";
            this.SaveButtom.Size = new System.Drawing.Size(150, 23);
            this.SaveButtom.TabIndex = 6;
            this.SaveButtom.Text = "Save";
            this.SaveButtom.UseVisualStyleBackColor = true;
            this.SaveButtom.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // allocatedHourstextBox
            // 
            this.allocatedHourstextBox.Location = new System.Drawing.Point(46, 222);
            this.allocatedHourstextBox.Name = "allocatedHourstextBox";
            this.allocatedHourstextBox.Size = new System.Drawing.Size(150, 22);
            this.allocatedHourstextBox.TabIndex = 3;
            // 
            // AddProjectsControl
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.SaveButtom);
            this.Name = "AddProjectsControl";
            this.Size = new System.Drawing.Size(1262, 743);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox addresscomboBox;
        private System.Windows.Forms.ComboBox buildingcomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox budgetTextbox;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Button SaveButtom;
        private System.Windows.Forms.TextBox allocatedHourstextBox;
    }
}
