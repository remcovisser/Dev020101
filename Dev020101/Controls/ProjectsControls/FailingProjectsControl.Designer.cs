namespace Dev020101.Controls.ProjectsControls
{
    partial class FailingProjectsControl
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
            this.FailingProjectsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FailingProjectsListBox
            // 
            this.FailingProjectsListBox.FormattingEnabled = true;
            this.FailingProjectsListBox.ItemHeight = 16;
            this.FailingProjectsListBox.Location = new System.Drawing.Point(0, 1);
            this.FailingProjectsListBox.Name = "FailingProjectsListBox";
            this.FailingProjectsListBox.Size = new System.Drawing.Size(1259, 740);
            this.FailingProjectsListBox.TabIndex = 0;
            // 
            // FailingProjectsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FailingProjectsListBox);
            this.Name = "FailingProjectsControl";
            this.Size = new System.Drawing.Size(1262, 743);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FailingProjectsListBox;
    }
}
