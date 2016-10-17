namespace Dev020101.Controls.CitiesControls
{
    partial class ViewCitiesControl
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
            this.CitiesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CitiesList
            // 
            this.CitiesList.FormattingEnabled = true;
            this.CitiesList.ItemHeight = 16;
            this.CitiesList.Location = new System.Drawing.Point(0, 1);
            this.CitiesList.Name = "CitiesList";
            this.CitiesList.Size = new System.Drawing.Size(1262, 740);
            this.CitiesList.TabIndex = 2;
            this.CitiesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CitiesList_MouseDoubleClick);
            // 
            // ViewCitiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CitiesList);
            this.Name = "ViewCitiesControl";
            this.Size = new System.Drawing.Size(1262, 743);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CitiesList;
    }
}
