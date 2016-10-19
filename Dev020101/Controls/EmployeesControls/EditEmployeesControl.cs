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
        int currentSelectedDegree;

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
            updateAddressesList();

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

            // Add degrees tot he degreesList
            updateDegreesList();

            // Add courses to the combobox
            List<Courses> courses = new Courses().get();
            x = 0;
            foreach (Courses course in courses)
            {
                courseComboBox.Items.Insert(x, course.course_name);
                x++;
            }

            // Add schools to the combobox
            List<Schools> schools = new Schools().get();
            x = 0;
            foreach (Schools school in schools)
            {
                schoolComboBox.Items.Insert(x, school.school_name);
                x++;
            }

            // Add levels to the combobox
            List<Levels> levels = new Levels().get();
            x = 0;
            foreach (Levels level in levels)
            {
                levelComboBox.Items.Insert(x, level.level_name);
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
        // Clear the form
        private void clearAddressform()
        {
            numberTextBox.Text = "";
            postalcodeTextBox.Text = "";
            streetComboBox.SelectedIndex = 0;
            cityComboBox.SelectedIndex = 0;
            countryComboBox.SelectedIndex = 0;
            residenceCheckBox.Checked = false;
        }

        // Update the addressList
        private void updateAddressesList()
        {
            List<string> dataList = new List<string>();
            foreach (EmployeeAddresses employeeAddress in currentEmployee.addresses())
            {
                string adress = employeeAddress.address().street().street_name + " " + employeeAddress.address().number + " / " + employeeAddress.address().city().city_name + " / " + employeeAddress.address().country().country_name;
                dataList.Add(employeeAddress.address_id + " - " + adress);
            }
            AddressesList.DataSource = dataList;
        }

        // Save address clicked
        private void saveAddressButton_Click(object sender, EventArgs e)
        {
            // Save new Address
            if(currentSelectedAddress == 0)
            {
                Addresses newAddress = new Addresses();
                newAddress.number = numberTextBox.Text;
                newAddress.postalCode = postalcodeTextBox.Text;
                newAddress.street_id = new Streets().find(streetComboBox.Text, "street_name").grab().street_id;
                newAddress.city_id = new Cities().find(cityComboBox.Text, "city_name").grab().city_id;
                newAddress.country_id = new Countries().find(countryComboBox.Text, "country_name").grab().country_id;
                newAddress.save();

                EmployeeAddresses newEmployeeAddress = new EmployeeAddresses();
                newEmployeeAddress.bsn = currentEmployee.bsn;
                newEmployeeAddress.address_id = new Addresses().last("address_id").grab().address_id;
                newEmployeeAddress.residence = Convert.ToInt32(residenceCheckBox.Checked);
                newEmployeeAddress.save();

                feedbackLabel.Text = "The address has been created";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            // Update existing address
            else
            {
                Addresses updatedAddress = new Addresses().find(currentSelectedAddress, "address_id").grab();
                updatedAddress.number = numberTextBox.Text;
                updatedAddress.postalCode = postalcodeTextBox.Text;
                updatedAddress.street_id = new Streets().find(streetComboBox.Text, "street_name").grab().street_id;
                updatedAddress.city_id = new Cities().find(cityComboBox.Text, "city_name").grab().city_id;
                updatedAddress.country_id = new Countries().find(countryComboBox.Text, "country_name").grab().country_id;
                updatedAddress.update("address_id", currentSelectedAddress);

                feedbackLabel.Text = "The address has been updated";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }

            updateAddressesList();
        }

        // New address clicked
        private void newAddressButton_Click(object sender, EventArgs e)
        {
            currentSelectedAddress = 0;
            saveAddressButton.Text = "Save address";
            deleteAddressButton.Visible = false;

            // Clear the form
            clearAddressform();
        }

        // Delete address
        private void deleteAddressButton_Click(object sender, EventArgs e)
        {
            // Delete the employeeAddress
            new EmployeeAddresses().find(currentSelectedAddress, "address_id").grab().delete();
            // Delete the address
            new Addresses().find(currentSelectedAddress, "address_id").grab().delete();

            currentSelectedAddress = 0;
            clearAddressform();
            updateAddressesList();
            deleteAddressButton.Visible = false;

            feedbackLabel.Text = "The address has been deleted";
            feedbackLabel.ForeColor = System.Drawing.Color.Green;
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
                deleteAddressButton.Visible = true;
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
        // Clear the form
        private void clearDegreeform()
        {
            courseComboBox.SelectedIndex = 0;
            schoolComboBox.SelectedIndex = 0;
            levelComboBox.SelectedIndex = 0;
        }

        // Update the degreesList
        private void updateDegreesList()
        {
            List<string> dataList = new List<string>();
            foreach (EmployeeDegrees employeeDegree in currentEmployee.degrees())
            {
                string degree = employeeDegree.degree().course().course_name + " / " + employeeDegree.degree().school().school_name + " / " + employeeDegree.degree().level().level_name;
                dataList.Add(employeeDegree.degree_id + " - " + degree);
            }
            DegreesList.DataSource = dataList;
        }

        private void saveDegreeButton_Click(object sender, EventArgs e)
        {
            // Save new Address
            if (currentSelectedDegree == 0)
            {
                Degrees newDegree = new Degrees();
                newDegree.course_id = new Courses().find(courseComboBox.Text, "course_name").grab().course_id;
                newDegree.school_id = new Schools().find(schoolComboBox.Text, "school_name").grab().school_id;
                newDegree.level_id = new Levels().find(levelComboBox.Text, "level_name").grab().level_id;
                newDegree.save();

                EmployeeDegrees newEmployeeDegree = new EmployeeDegrees();
                newEmployeeDegree.degree_id = new Degrees().last("degree_id").grab().degree_id;
                newEmployeeDegree.bsn = currentEmployee.bsn;
                newEmployeeDegree.save();

                feedbackLabel.Text = "The degree has been created";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            // Update existing address
            else
            {
                Degrees updatedDegree = new Degrees().find(currentSelectedDegree, "degree_id").grab();
                updatedDegree.course_id = new Courses().find(courseComboBox.Text, "course_name").grab().course_id;
                updatedDegree.school_id = new Schools().find(schoolComboBox.Text, "school_name").grab().school_id;
                updatedDegree.level_id = new Levels().find(levelComboBox.Text, "level_name").grab().level_id;
                updatedDegree.update("degree_id", currentSelectedDegree);

                feedbackLabel.Text = "The degree has been updated";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }

            updateDegreesList();
        }

        private void newDegreeButton_Click(object sender, EventArgs e)
        {
            currentSelectedDegree = 0;
            saveDegreeButton.Text = "Save degree";
            deleteDegreeButton.Visible = false;

            // Clear the form
            clearDegreeform();
        }

        private void deleteDegreeButton_Click(object sender, EventArgs e)
        {
            // Delete the employeeDegree
            new EmployeeDegrees().find(currentSelectedDegree, "degree_id").grab().delete();
            // Delete the degree
            new Degrees().find(currentSelectedDegree, "degree_id").grab().delete();

            currentSelectedDegree = 0;
            clearDegreeform();
            updateDegreesList();
            deleteDegreeButton.Visible = false;

            feedbackLabel.Text = "The degree has been deleted";
            feedbackLabel.ForeColor = System.Drawing.Color.Green;
        }

        private void DegreesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.DegreesList.IndexFromPoint(e.Location);
            if (DegreesList.SelectedItem != null)
            {
                string degree_id = DegreesList.SelectedItem.ToString().Split('-').First().Trim(' ');
                currentSelectedDegree = Int32.Parse(degree_id);
                newDegreeButton.Visible = true;
                deleteDegreeButton.Visible = true;
                Degrees selectedDegree = new Degrees().find(degree_id, "degree_id").grab();

                courseComboBox.Text = selectedDegree.course().course_name;
                schoolComboBox.Text = selectedDegree.school().school_name;
                levelComboBox.Text = selectedDegree.level().level_name;

                saveAddressButton.Text = "Update degree";
            }
        }


        // --------------- User positions ----------------------------// 
    }
}
