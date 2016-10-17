namespace Dev020101.Controls.SchoolsControls
{
    partial class ViewSchoolsControl
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
            this.SchoolsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SchoolsList
            // 
            this.SchoolsList.FormattingEnabled = true;
            this.SchoolsList.ItemHeight = 16;
            this.SchoolsList.Location = new System.Drawing.Point(0, 1);
            this.SchoolsList.Name = "SchoolsList";
            this.SchoolsList.Size = new System.Drawing.Size(1262, 740);
            this.SchoolsList.TabIndex = 3;
            this.SchoolsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SchoolsList_MouseDoubleClick);
            // 
            // ViewSchoolsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SchoolsList);
            this.Name = "ViewSchoolsControl";
            this.Size = new System.Drawing.Size(1262, 743);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SchoolsList;
    }
}
