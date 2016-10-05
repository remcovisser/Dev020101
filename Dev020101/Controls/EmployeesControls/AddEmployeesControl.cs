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
    public partial class AddEmployeesControl : UserControl
    {
        public AddEmployeesControl()
        {
            InitializeComponent();
        }

        private void SaveButtom_Click(object sender, EventArgs e)
        {
            Employees newEmployee = new Employees();
            newEmployee.firstName = firstnameTextbox.Text;
            newEmployee.lastName = lastnameTextbox.Text;
            newEmployee.save();
        }
    }
}
