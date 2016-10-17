using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Dev020101.Models;

namespace Dev020101.Controls.LevelsControls
{
    public partial class AddLevelsControl : UserControl
    {
        public AddLevelsControl()
        {
            InitializeComponent();
        }

        // Check if there is a level with the given name
        private bool levelsUnique(string name)
        {
            if (new Levels().find(name, "level_name").count() == 0)
            {
                return true;
            }
            return false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (levelsUnique(nameTextbox.Text))
            {
                Levels newLevel = new Levels();
                newLevel.level_name = nameTextbox.Text;
                newLevel.save();

                feedbackLabel.Text = "The level has been created";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "There is already a level with that name";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
