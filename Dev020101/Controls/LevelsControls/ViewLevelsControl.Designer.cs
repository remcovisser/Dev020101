namespace Dev020101.Controls.LevelsControls
{
    partial class ViewLevelsControl
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
            this.LevelsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LevelsList
            // 
            this.LevelsList.FormattingEnabled = true;
            this.LevelsList.ItemHeight = 16;
            this.LevelsList.Location = new System.Drawing.Point(0, 1);
            this.LevelsList.Name = "LevelsList";
            this.LevelsList.Size = new System.Drawing.Size(1262, 740);
            this.LevelsList.TabIndex = 3;
            this.LevelsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LevelsList_MouseDoubleClick);
            // 
            // ViewLevelsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LevelsList);
            this.Name = "ViewLevelsControl";
            this.Size = new System.Drawing.Size(1262, 743);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LevelsList;
    }
}
