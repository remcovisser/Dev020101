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

namespace Dev020101.Controls.ProjectsControls
{
    public partial class ViewProjectsControl : UserControl
    {
        Projects projects = new Projects();

        public ViewProjectsControl()
        {
            InitializeComponent();

            List<string> dataList = new List<string>();
            foreach (Projects project in projects.get())
            {
                dataList.Add(project.project_id + " - " + project.name);
            }

           ProjectsList.DataSource = dataList;
        }

        // Switch active control
        private void changeControl(Control Control)
        {
            this.ActiveControl.Controls.Clear();
            this.ActiveControl.Controls.Add(Control);
        }

        // User clicked
        private void ProjectsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.ProjectsList.IndexFromPoint(e.Location);
            if (ProjectsList.SelectedItem != null)
            {
                string project_id = ProjectsList.SelectedItem.ToString().Split('=').First().Trim(' ');
                Projects selectedProject = projects.find(project_id, "project_id").grab();

                changeControl(new EditProjectsControl(selectedProject));
            }
        }
    }
}
