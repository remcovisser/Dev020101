namespace Dev020101.Controls.HeadquartersControls
{
    partial class ViewHeadquartersControl
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
            this.HeadquartersList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // HeadquartersList
            // 
            this.HeadquartersList.FormattingEnabled = true;
            this.HeadquartersList.ItemHeight = 16;
            this.HeadquartersList.Location = new System.Drawing.Point(0, 0);
            this.HeadquartersList.Name = "HeadquartersList";
            this.HeadquartersList.Size = new System.Drawing.Size(1262, 740);
            this.HeadquartersList.TabIndex = 2;
            this.HeadquartersList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.HeadquartersList_MouseDoubleClick);
            // 
            // ViewHeadquartersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HeadquartersList);
            this.Name = "ViewHeadquartersControl";
            this.Size = new System.Drawing.Size(1262, 740);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox HeadquartersList;
    }
}
