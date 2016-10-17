namespace Dev020101.Controls.LevelsControls
{
    partial class EditLevelsControl
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
            this.SuspendLayout();
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(61, 576);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(0, 17);
            this.feedbackLabel.TabIndex = 31;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(64, 674);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 23);
            this.deleteButton.TabIndex = 29;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Name";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(64, 63);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(150, 22);
            this.nameTextbox.TabIndex = 27;
            // 
            // SaveButtom
            // 
            this.SaveButtom.Location = new System.Drawing.Point(64, 617);
            this.SaveButtom.Name = "SaveButtom";
            this.SaveButtom.Size = new System.Drawing.Size(150, 23);
            this.SaveButtom.TabIndex = 28;
            this.SaveButtom.Text = "Save";
            this.SaveButtom.UseVisualStyleBackColor = true;
            this.SaveButtom.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // EditLevelsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.SaveButtom);
            this.Name = "EditLevelsControl";
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
    }
}
