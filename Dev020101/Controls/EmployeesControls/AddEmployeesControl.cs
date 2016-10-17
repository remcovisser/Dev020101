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

            // Add headquarters to the combobox
            List<Headquarters> headquaters = new Headquarters().get();
            int x = 0;
            foreach(Headquarters headquarter in headquaters)
            {
                headquartersComboBox.Items.Insert(x, headquarter.buildingName);
                x++;
            }
        }

        // Check if there is an employee with the given BSN
        private bool employeeUnique(string bsn)
        {
            if(new Employees().find(bsn, "bsn").count() == 0)
            {
                return true;
            }
            return false;
        }

        // Save the new user
        private void SaveButtom_Click(object sender, EventArgs e)
        {
            if (employeeUnique(bsnTextbox.Text))
            {
                Employees newEmployee = new Employees();
                newEmployee.bsn = bsnTextbox.Text;
                newEmployee.firstName = firstnameTextbox.Text;
                newEmployee.lastName = lastnameTextbox.Text;
                newEmployee.buildingName = headquartersComboBox.Text;
                newEmployee.save();

                feedbackLabel.Text = "The employee has been created";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "There is already an employee with that BSN";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
