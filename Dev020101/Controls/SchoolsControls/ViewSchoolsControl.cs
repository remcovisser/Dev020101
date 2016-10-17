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
    public partial class ViewSchoolsControl : UserControl
    {
        Schools schools = new Schools();

        public ViewSchoolsControl()
        {
            InitializeComponent();

            List<string> dataList = new List<string>();
            foreach (Schools school in schools.get())
            {
                dataList.Add(school.school_name);
            }

            SchoolsList.DataSource = dataList;
        }

        // Switch active control
        private void changeControl(Control Control)
        {
            this.ActiveControl.Controls.Clear();
            this.ActiveControl.Controls.Add(Control);
        }

        private void SchoolsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.SchoolsList.IndexFromPoint(e.Location);
            if (SchoolsList.SelectedItem != null)
            {
                string name = SchoolsList.SelectedItem.ToString();
                Schools selectedSchool = schools.find(name, "school_name").grab();

                changeControl(new EditSchoolsControl(selectedSchool));
            }
        }
    }
}
