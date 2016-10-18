using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Dev020101.Controls.EmployeesControls;
using Dev020101.Controls.HeadquartersControls;
using Dev020101.Controls.CitiesControls;
using Dev020101.Controls.CountriesControls;
using Dev020101.Controls.CoursesControls;
using Dev020101.Controls.LevelsControls;
using Dev020101.Controls.SchoolsControls;
using Dev020101.Controls.PositionsControls;
using Dev020101.Controls.StreetsControls;
using Dev020101.Controls.ProjectsControls;

namespace Dev020101
{
    public partial class Form1 : Form
    {
        // Home
        public Form1()
        {
            InitializeComponent();
        }

        // Switch active control
        private void changeControl(Control Control)
        {
            activeView.Controls.Clear();
            activeView.Controls.Add(Control);
        }

        // Home button
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Employees overview
        private void viewEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new ViewEmployeesControl());
        }
        // Add employee
        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new AddEmployeesControl());
        }


        // Headquarters overview
        private void viewHeadquartersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new ViewHeadquartersControl());
        }
        // Add Headquarters
        private void addHeadquartersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new AddHeadquartersControl());
        }

        // Cities overview
        private void viewCitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new ViewCitiesControl());
        }
        // Add cities
        private void addCitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new AddCitiesControl());
        }

        // Cuntries overview
        private void viewCountriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new ViewCountriesControl());
        }
        // Add countries
        private void addCountriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new AddCountriesControl());
        }

        // Levels overview
        private void viewLevelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new ViewLevelsControl());
        }
        // Add levels
        private void addLevelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new AddLevelsControl());
        }

        // Courses overview
        private void viewCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new ViewCoursesControl());
        }
        // Add courses
        private void addCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new AddCoursesControl());
        }

        // Schools overview
        private void viewSchoolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new ViewSchoolsControl());
        }
        // Add schools
        private void addSchoolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new AddSchoolsControl());
        }

        // Positions overview
        private void viewPositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new ViewPositionsControl());
        }
        // Add positions
        private void addPositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new AddPositionsControl());
        }

        // Streets overview
        private void viewStreetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new ViewStreetsControl());
        }
        // Add streets
        private void addStreetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new AddStreetsControl());
        }

        // View projects
        private void viewProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new ViewProjectsControl());
        }
        // Add projects
        private void addProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeControl(new AddProjectsControl());
        }
    }
}
