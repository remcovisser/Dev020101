namespace Dev020101.Controls.ProjectsControls
{
    partial class ViewProjectsControl
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
            this.ProjectsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ProjectsList
            // 
            this.ProjectsList.FormattingEnabled = true;
            this.ProjectsList.ItemHeight = 16;
            this.ProjectsList.Location = new System.Drawing.Point(0, 1);
            this.ProjectsList.Name = "ProjectsList";
            this.ProjectsList.Size = new System.Drawing.Size(1262, 740);
            this.ProjectsList.TabIndex = 3;
            this.ProjectsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ProjectsList_MouseDoubleClick);
            // 
            // ViewProjectsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProjectsList);
            this.Name = "ViewProjectsControl";
            this.Size = new System.Drawing.Size(1262, 743);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ProjectsList_MouseDoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ProjectsList;
    }
}
