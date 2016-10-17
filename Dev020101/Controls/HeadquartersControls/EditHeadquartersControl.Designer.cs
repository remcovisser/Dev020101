namespace Dev020101.Controls.HeadquartersControls
{
    partial class EditHeadquartersControl
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
            this.buildingNameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rentTextbox = new System.Windows.Forms.TextBox();
            this.roomsTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SaveButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Bulding name";
            // 
            // buildingNameTextbox
            // 
            this.buildingNameTextbox.Location = new System.Drawing.Point(95, 67);
            this.buildingNameTextbox.Name = "buildingNameTextbox";
            this.buildingNameTextbox.Size = new System.Drawing.Size(150, 22);
            this.buildingNameTextbox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Rent";
            // 
            // rentTextbox
            // 
            this.rentTextbox.Location = new System.Drawing.Point(95, 244);
            this.rentTextbox.Name = "rentTextbox";
            this.rentTextbox.Size = new System.Drawing.Size(150, 22);
            this.rentTextbox.TabIndex = 27;
            // 
            // roomsTextbox
            // 
            this.roomsTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomsTextbox.Location = new System.Drawing.Point(95, 154);
            this.roomsTextbox.Name = "roomsTextbox";
            this.roomsTextbox.Size = new System.Drawing.Size(150, 22);
            this.roomsTextbox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Rooms";
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(92, 529);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(0, 17);
            this.feedbackLabel.TabIndex = 34;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(95, 627);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 23);
            this.deleteButton.TabIndex = 33;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // SaveButtom
            // 
            this.SaveButtom.Location = new System.Drawing.Point(95, 570);
            this.SaveButtom.Name = "SaveButtom";
            this.SaveButtom.Size = new System.Drawing.Size(150, 23);
            this.SaveButtom.TabIndex = 32;
            this.SaveButtom.Text = "Save";
            this.SaveButtom.UseVisualStyleBackColor = true;
            this.SaveButtom.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // EditHeadquartersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.SaveButtom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buildingNameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rentTextbox);
            this.Controls.Add(this.roomsTextbox);
            this.Controls.Add(this.label1);
            this.Name = "EditHeadquartersControl";
            this.Size = new System.Drawing.Size(1262, 743);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox buildingNameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rentTextbox;
        private System.Windows.Forms.TextBox roomsTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button SaveButtom;
    }
}
