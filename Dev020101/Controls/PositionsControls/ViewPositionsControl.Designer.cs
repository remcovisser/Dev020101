namespace Dev020101.Controls.PositionsControls
{
    partial class ViewPositionsControl
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
            this.PositionsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PositionsList
            // 
            this.PositionsList.FormattingEnabled = true;
            this.PositionsList.ItemHeight = 16;
            this.PositionsList.Location = new System.Drawing.Point(0, 1);
            this.PositionsList.Name = "PositionsList";
            this.PositionsList.Size = new System.Drawing.Size(1262, 740);
            this.PositionsList.TabIndex = 4;
            this.PositionsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PositionsList_MouseDoubleClick);
            // 
            // ViewPositionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PositionsList);
            this.Name = "ViewPositionsControl";
            this.Size = new System.Drawing.Size(1262, 743);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PositionsList;
    }
}
