namespace Dev020101.Controls.CountriesControls
{
    partial class ViewCountriesControl
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
            this.CountriesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CountriesList
            // 
            this.CountriesList.FormattingEnabled = true;
            this.CountriesList.ItemHeight = 16;
            this.CountriesList.Location = new System.Drawing.Point(0, 1);
            this.CountriesList.Name = "CountriesList";
            this.CountriesList.Size = new System.Drawing.Size(1262, 740);
            this.CountriesList.TabIndex = 3;
            this.CountriesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CountriesList_MouseDoubleClick);
            // 
            // ViewCountriesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CountriesList);
            this.Name = "ViewCountriesControl";
            this.Size = new System.Drawing.Size(1262, 743);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CountriesList_MouseDoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CountriesList;
    }
}
