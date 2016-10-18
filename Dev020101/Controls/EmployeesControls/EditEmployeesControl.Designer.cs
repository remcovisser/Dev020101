namespace Dev020101.Controls.EmployeesControls
{
    partial class EditEmployeesControl
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
            this.SaveButtom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.firstnameTextbox = new System.Windows.Forms.TextBox();
            this.lastnameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bsnTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.headquartersComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.streetComboBox = new System.Windows.Forms.ComboBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.residenceCheckBox = new System.Windows.Forms.CheckBox();
            this.AddressList = new System.Windows.Forms.ListBox();
            this.newAddressbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveButtom
            // 
            this.SaveButtom.Location = new System.Drawing.Point(164, 627);
            this.SaveButtom.Name = "SaveButtom";
            this.SaveButtom.Size = new System.Drawing.Size(150, 23);
            this.SaveButtom.TabIndex = 4;
            this.SaveButtom.Text = "Save";
            this.SaveButtom.UseVisualStyleBackColor = true;
            this.SaveButtom.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firstname";
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.Location = new System.Drawing.Point(164, 160);
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.Size = new System.Drawing.Size(150, 22);
            this.firstnameTextbox.TabIndex = 2;
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox.Location = new System.Drawing.Point(164, 250);
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.Size = new System.Drawing.Size(150, 22);
            this.lastnameTextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lastname";
            // 
            // bsnTextbox
            // 
            this.bsnTextbox.Location = new System.Drawing.Point(164, 73);
            this.bsnTextbox.Name = "bsnTextbox";
            this.bsnTextbox.Size = new System.Drawing.Size(150, 22);
            this.bsnTextbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "BSN";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(164, 684);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(161, 586);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(0, 17);
            this.feedbackLabel.TabIndex = 15;
            // 
            // headquartersComboBox
            // 
            this.headquartersComboBox.FormattingEnabled = true;
            this.headquartersComboBox.Location = new System.Drawing.Point(164, 340);
            this.headquartersComboBox.Name = "headquartersComboBox";
            this.headquartersComboBox.Size = new System.Drawing.Size(150, 24);
            this.headquartersComboBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Headquarters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Number";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(452, 73);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(150, 22);
            this.numberTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Postalcode";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(452, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 22);
            this.textBox2.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Street";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Country";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(449, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Residence";
            // 
            // streetComboBox
            // 
            this.streetComboBox.FormattingEnabled = true;
            this.streetComboBox.Location = new System.Drawing.Point(452, 250);
            this.streetComboBox.Name = "streetComboBox";
            this.streetComboBox.Size = new System.Drawing.Size(150, 24);
            this.streetComboBox.TabIndex = 30;
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(452, 340);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(150, 24);
            this.cityComboBox.TabIndex = 31;
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(452, 424);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(150, 24);
            this.countryComboBox.TabIndex = 32;
            // 
            // residenceCheckBox
            // 
            this.residenceCheckBox.AutoSize = true;
            this.residenceCheckBox.Location = new System.Drawing.Point(452, 504);
            this.residenceCheckBox.Name = "residenceCheckBox";
            this.residenceCheckBox.Size = new System.Drawing.Size(18, 17);
            this.residenceCheckBox.TabIndex = 33;
            this.residenceCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddressList
            // 
            this.AddressList.FormattingEnabled = true;
            this.AddressList.ItemHeight = 16;
            this.AddressList.Location = new System.Drawing.Point(711, 73);
            this.AddressList.Name = "AddressList";
            this.AddressList.Size = new System.Drawing.Size(138, 388);
            this.AddressList.TabIndex = 34;
            this.AddressList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AddressList_MouseDoubleClick);
            // 
            // newAddressbutton
            // 
            this.newAddressbutton.Location = new System.Drawing.Point(711, 497);
            this.newAddressbutton.Name = "newAddressbutton";
            this.newAddressbutton.Size = new System.Drawing.Size(138, 23);
            this.newAddressbutton.TabIndex = 35;
            this.newAddressbutton.Text = "New address";
            this.newAddressbutton.UseVisualStyleBackColor = true;
            this.newAddressbutton.Visible = false;
            this.newAddressbutton.Click += new System.EventHandler(this.newAddressButton_Click);
            // 
            // EditEmployeesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newAddressbutton);
            this.Controls.Add(this.AddressList);
            this.Controls.Add(this.residenceCheckBox);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.streetComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.headquartersComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bsnTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastnameTextbox);
            this.Controls.Add(this.firstnameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButtom);
            this.Name = "EditEmployeesControl";
            this.Size = new System.Drawing.Size(1262, 740);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButtom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstnameTextbox;
        private System.Windows.Forms.TextBox lastnameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bsnTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.ComboBox headquartersComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox streetComboBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.CheckBox residenceCheckBox;
        private System.Windows.Forms.ListBox AddressList;
        private System.Windows.Forms.Button newAddressbutton;
    }
}
