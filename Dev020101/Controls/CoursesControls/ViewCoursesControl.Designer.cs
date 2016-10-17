namespace Dev020101.Controls.CoursesControls
{
    partial class ViewCoursesControl
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
            this.CoursesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CoursesList
            // 
            this.CoursesList.FormattingEnabled = true;
            this.CoursesList.ItemHeight = 16;
            this.CoursesList.Location = new System.Drawing.Point(0, 1);
            this.CoursesList.Name = "CoursesList";
            this.CoursesList.Size = new System.Drawing.Size(1262, 740);
            this.CoursesList.TabIndex = 3;
            this.CoursesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CoursesList_MouseDoubleClick);
            // 
            // ViewCoursesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CoursesList);
            this.Name = "ViewCoursesControl";
            this.Size = new System.Drawing.Size(1262, 743);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CoursesList;
    }
}
