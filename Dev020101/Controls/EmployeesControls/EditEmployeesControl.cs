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
        int currentSelectedAddress;

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
                string adress = employeeAddress.address().street().street_name + " " + employeeAddress.address().number + " / " + employeeAddress.address().city().city_name + " / " + employeeAddress.address().country().country_name;
                dataList.Add(employeeAddress.address_id + " - " + adress);
            }
            AddressesList.DataSource = dataList;

            // Add streets to the combobox
            List<Streets> streets = new Streets().get();
            x = 0;
            foreach (Streets street in streets)
            {
                streetComboBox.Items.Insert(x, street.street_name);
                x++;
            }

            // Add cities to the combobox
            List<Cities> cities = new Cities().get();
            x = 0;
            foreach (Cities city in cities)
            {
                cityComboBox.Items.Insert(x, city.city_name);
                x++;
            }

            // Add countries to the combobox
            List<Countries> countries = new Countries().get();
            x = 0;
            foreach (Countries country in countries)
            {
                countryComboBox.Items.Insert(x, country.country_name);
                x++;
            }
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


        // --------------- User addressess ----------------------------// 
        // Save address clicked
        private void saveAddressButton_Click(object sender, EventArgs e)
        {

        }

        // New address clicked
        private void newAddressButton_Click(object sender, EventArgs e)
        {
            currentSelectedAddress = 0;
            saveAddressButton.Text = "Save address";

            // Clear the form
            numberTextBox.Text = "";
            postalcodeTextBox.Text = "";
            streetComboBox.SelectedIndex = 0;
            cityComboBox.SelectedIndex = 0;
            countryComboBox.SelectedIndex = 0;
            residenceCheckBox.Checked = false;
        }

        // Delete address
        private void deleteAddressButton_Click(object sender, EventArgs e)
        {
            currentSelectedAddress = 0;
        }

        // Adress selected
        private void AddressList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.AddressesList.IndexFromPoint(e.Location);
            if (AddressesList.SelectedItem != null)
            {
                string address_id = AddressesList.SelectedItem.ToString().Split('-').First().Trim(' ');
                currentSelectedAddress = Int32.Parse(address_id);
                newAddressButton.Visible = true;
                Addresses selectedAddress = new Addresses().find(address_id, "address_id").grab();

                numberTextBox.Text = selectedAddress.number.ToString();
                postalcodeTextBox.Text = selectedAddress.postalCode;
                streetComboBox.SelectedText = selectedAddress.street().street_name;
                cityComboBox.SelectedText = selectedAddress.city().city_name;
                countryComboBox.SelectedText = selectedAddress.country().country_name;
                residenceCheckBox.Checked = Convert.ToBoolean(selectedAddress.employeeAddress().residence);
                saveAddressButton.Text = "Update address";
            }
        }


        // --------------- User degrees ----------------------------// 


        // --------------- User positions ----------------------------// 
    }
}
