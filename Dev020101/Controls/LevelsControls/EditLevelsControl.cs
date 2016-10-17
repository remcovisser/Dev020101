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
    public partial class EditLevelsControl : UserControl
    {
        Levels currentLevel;

        public EditLevelsControl(Levels selectedLevel)
        {
            InitializeComponent();

            // Fill the field with data
            currentLevel = selectedLevel;
            nameTextbox.Text = selectedLevel.level_name;
        }

        // Check if there is a level with the given name
        private bool levelUnique(string name)
        {
            if (new Levels().find(name, "level_name").count() == 0)
            {
                return true;
            }
            return false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (levelUnique(nameTextbox.Text))
            {
                Levels updatedLevel = new Levels();
                updatedLevel.level_name = nameTextbox.Text;
                updatedLevel.update("level_name", currentLevel.level_name);

                currentLevel = updatedLevel;

                feedbackLabel.Text = "The level has been updated";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "There is already a level with that name";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool deleteFeedback = new Levels().find(currentLevel.level_name, "level_name").grab().delete();

            if (deleteFeedback)
            {
                feedbackLabel.Text = "The level has been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "The level has NOT been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
