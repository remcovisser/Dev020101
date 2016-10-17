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

namespace Dev020101.Controls.CoursesControls
{
    public partial class AddCoursesControl : UserControl
    {

        public AddCoursesControl()
        {
            InitializeComponent();
        }

        // Check if there is an course with the given BSN
        private bool courseUnique(string name)
        {
            if (new Courses().find(name, "course_name").count() == 0)
            {
                return true;
            }
            return false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (courseUnique(nameTextbox.Text))
            {
                Courses newCourse = new Courses();
                newCourse.course_name = nameTextbox.Text;
                newCourse.save();

                feedbackLabel.Text = "The course has been created";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "There is already a course with that name";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
