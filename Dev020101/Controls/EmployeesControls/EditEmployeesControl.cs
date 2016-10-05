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
    public partial class EditEmployeesControl : UserControl
    {
        Employees currentEmployee;

        // Load the data in the view
        public EditEmployeesControl(Employees selectedEmployee)
        {
            InitializeComponent();

            currentEmployee = selectedEmployee;
            bsnTextbox.Text = selectedEmployee.bsn.ToString();
            firstnameTextbox.Text = selectedEmployee.firstName;
            lastnameTextbox.Text = selectedEmployee.lastName;
        }

        // Save the updated user
        private void saveButton_Click(object sender, EventArgs e)
        {
            Employees updatedEmployee = new Employees();
            updatedEmployee.bsn = currentEmployee.bsn;
            updatedEmployee.firstName = firstnameTextbox.Text;
            updatedEmployee.lastName = lastnameTextbox.Text;
            updatedEmployee.update("bsn");
        }
    }
}
