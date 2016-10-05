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

namespace Dev020101.Controls.EmployeesControls
{
    public partial class ViewEmployeesControl : UserControl
    {
        Employees employees = new Employees();

        // Switch active control
        private void changeControl(Control Control)
        {
            this.ActiveControl.Controls.Clear();
            this.ActiveControl.Controls.Add(Control);
        }

        // Show all employees
        public ViewEmployeesControl()
        {
            InitializeComponent();

            List<string> dataList = new List<string>();
            foreach (Employees employee in employees.get())
            {
                dataList.Add(employee.bsn + " - " + employee.fullname());
            }

            EmployeesList.DataSource = dataList;
        }

        // User clicked
        private void EmployeesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.EmployeesList.IndexFromPoint(e.Location);
            if (EmployeesList.SelectedItem != null)
            {
                string id = EmployeesList.SelectedItem.ToString().Split('-').First().Trim(' ');
                Employees selectedEmployee = employees.find(id, "bsn").grab();

                changeControl(new EditEmployeesControl(selectedEmployee));
            }
        }
    }
}
