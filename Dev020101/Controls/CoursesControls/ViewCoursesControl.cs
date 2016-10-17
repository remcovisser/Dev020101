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
    public partial class ViewCoursesControl : UserControl
    {
        Courses courses = new Courses();

        public ViewCoursesControl()
        {
            InitializeComponent();

            List<string> dataList = new List<string>();
            foreach (Courses course in courses.get())
            {
                dataList.Add(course.course_name);
            }

            CoursesList.DataSource = dataList;
        }

        // Switch active control
        private void changeControl(Control Control)
        {
            this.ActiveControl.Controls.Clear();
            this.ActiveControl.Controls.Add(Control);
        }

        private void CoursesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.CoursesList.IndexFromPoint(e.Location);
            if (CoursesList.SelectedItem != null)
            {
                string name = CoursesList.SelectedItem.ToString();
                Courses selectedCourse = courses.find(name, "course_name").grab();

                changeControl(new EditCoursesControl(selectedCourse));
            }
        }
    }
}
