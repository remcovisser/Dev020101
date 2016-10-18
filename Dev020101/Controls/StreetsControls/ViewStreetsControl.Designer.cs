namespace Dev020101.Controls.StreetsControls
{
    partial class ViewStreetsControl
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
            this.StreetsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // StreetsList
            // 
            this.StreetsList.FormattingEnabled = true;
            this.StreetsList.ItemHeight = 16;
            this.StreetsList.Location = new System.Drawing.Point(0, 1);
            this.StreetsList.Name = "StreetsList";
            this.StreetsList.Size = new System.Drawing.Size(1262, 740);
            this.StreetsList.TabIndex = 4;
            this.StreetsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.StreetsList_MouseDoubleClick);
            // 
            // ViewStreetsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StreetsList);
            this.Name = "ViewStreetsControl";
            this.Size = new System.Drawing.Size(1262, 743);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StreetsList;
    }
}
