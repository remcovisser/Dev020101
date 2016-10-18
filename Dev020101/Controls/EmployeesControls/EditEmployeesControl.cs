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

            // Fill the field with data
            currentEmployee = selectedEmployee;
            bsnTextbox.Text = selectedEmployee.bsn;
            firstnameTextbox.Text = selectedEmployee.firstName;
            lastnameTextbox.Text = selectedEmployee.lastName;
            // Add headquarters to the combobox
            List<Headquarters> headquaters = new Headquarters().get();
            int x = 0;
            foreach (Headquarters headquarter in headquaters)
            {
                headquartersComboBox.Items.Insert(x, headquarter.buildingName);
                x++;
            }
            headquartersComboBox.SelectedText = currentEmployee.buildingName;
            // Add addresses to the listbox
            List<string> dataList = new List<string>();
            foreach (EmployeeAddresses employeeAddress in currentEmployee.addresses())
            {
                string adress = employeeAddress.address().street().street_name;
                dataList.Add(employeeAddress.address_id + " - " + adress);
            }
            AddressList.DataSource = dataList;
        }

        // Check if there is an employee with the given BSN
        private bool employeeUnique(string bsn)
        {
            if (bsn == currentEmployee.bsn || new Employees().find(bsn, "bsn").count() == 0)
            {
                return true;
            }
            return false;
        }

        // Save the current updated user
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (employeeUnique(bsnTextbox.Text))
            {
                Employees updatedEmployee = new Employees();
                updatedEmployee.bsn = bsnTextbox.Text;
                updatedEmployee.firstName = firstnameTextbox.Text;
                updatedEmployee.lastName = lastnameTextbox.Text;
                updatedEmployee.buildingName = headquartersComboBox.Text;
                updatedEmployee.update("bsn", currentEmployee.bsn);

                currentEmployee = updatedEmployee;

                feedbackLabel.Text = "The employee has been updated";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "There is already an employee with that BSN";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        // Delete the current user
        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool deleteFeedback = new Employees().find(currentEmployee.bsn, "bsn").grab().delete();

            if(deleteFeedback)
            {
                feedbackLabel.Text = "The employee has been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "The employee has NOT been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        // New Adress clicked
        private void newAddressButton_Click(object sender, EventArgs e)
        {
            // Clear the form
            numberTextBox.Text = "";
        }

        // Adress selected
        private void AddressList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            newAddressbutton.Visible = true;

            // Fill the form
            int index = this.AddressList.IndexFromPoint(e.Location);
            if (AddressList.SelectedItem != null)
            {
                string address_id = AddressList.SelectedItem.ToString().Split('-').First().Trim(' ');
                Addresses selectedAddress = new Addresses().find(address_id, "address_id").grab();

                numberTextBox.Text = selectedAddress.number.ToString();
            }
        }
    }
}
