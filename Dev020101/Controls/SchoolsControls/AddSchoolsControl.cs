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
    public partial class AddSchoolsControl : UserControl
    {
        public AddSchoolsControl()
        {
            InitializeComponent();
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
                Schools newSchool = new Schools();
                newSchool.school_name = nameTextbox.Text;
                newSchool.save();

                feedbackLabel.Text = "The school has been created";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "There is already a school with that name";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
