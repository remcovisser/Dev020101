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

namespace Dev020101.Controls.SchoolsControls
{
    public partial class EditSchoolsControl : UserControl
    {
        Schools currentSchool;

        public EditSchoolsControl(Schools selectedSchool)
        {
            InitializeComponent();

            // Fill the field with data
            currentSchool = selectedSchool;
            nameTextbox.Text = selectedSchool.school_name;
        }

        // Check if there is a school with the given name
        private bool schoolUnique(string name)
        {
            if (new Schools().find(name, "school_name").count() == 0)
            {
                return true;
            }
            return false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (schoolUnique(nameTextbox.Text))
            {
                Schools updateSchool = new Schools();
                updateSchool.school_name = nameTextbox.Text;
                updateSchool.update("school_name", currentSchool.school_name);

                currentSchool = updateSchool;

                feedbackLabel.Text = "The school has been updated";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "There is already a school with that name";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool deleteFeedback = new Schools().find(currentSchool.school_name, "school_name").grab().delete();

            if (deleteFeedback)
            {
                feedbackLabel.Text = "The school has been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "The school has NOT been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
