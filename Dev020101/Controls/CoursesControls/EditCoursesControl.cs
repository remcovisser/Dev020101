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
    public partial class EditCoursesControl : UserControl
    {
        Courses currentCourse;

        public EditCoursesControl(Courses selectedCourse)
        {
            InitializeComponent();

            // Fill the field with data
            currentCourse = selectedCourse;
            nameTextbox.Text = selectedCourse.course_name;
        }

        // Check if there is an course with the given BSN
        private bool courseUnique(string name)
        {
            if (name == currentCourse.course_name || new Courses().find(name, "course_name").count() == 0)
            {
                return true;
            }
            return false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (courseUnique(nameTextbox.Text))
            {
                Courses updatedCourse = new Courses();
                updatedCourse.course_id = currentCourse.course_id;
                updatedCourse.course_name = nameTextbox.Text;
                updatedCourse.update("course_name", currentCourse.course_name);

                currentCourse = updatedCourse;

                feedbackLabel.Text = "The course has been updated";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "There is already a course with that name";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool deleteFeedback = new Courses().find(currentCourse.course_id, "course_id").grab().delete();

            if (deleteFeedback)
            {
                feedbackLabel.Text = "The course has been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "The course has NOT been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
