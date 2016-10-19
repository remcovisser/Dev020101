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
    public partial class FailingProjectsControl : UserControl
    {
        public FailingProjectsControl()
        {
            InitializeComponent();

            // Check what projects cannot pay the rent, that is, the rent is higher than 10 % of their budget.
            List<Projects> projects = new Projects().get();
            List<string> failingProjects = new List<string>();

            foreach(Projects project in projects)
            {
                if(project.headquarter().rent > (project.budget / 100 * 10))
                {
                    failingProjects.Add(project.project_id + " - " + project.name + " | Rent: " + project.headquarter().rent + " > 10% of budget: " + project.budget);
                }
            }

            FailingProjectsListBox.DataSource = failingProjects;
        }
    }
}
