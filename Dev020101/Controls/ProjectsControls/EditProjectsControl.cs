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
    public partial class EditProjectsControl : UserControl
    {
        Projects currentProject;

        public EditProjectsControl(Projects selectedProject)
        {
            InitializeComponent();

            // Fill the field with data
            currentProject = selectedProject;
            nameTextbox.Text = selectedProject.name;
            budgetTextbox.Text = selectedProject.budget.ToString();
            allocatedHourstextBox.Text = selectedProject.allocatedHours.ToString();
            
            // Add headquarters to the combobox
            List<Headquarters> headquaters = new Headquarters().get();
            int x = 0;
            foreach (Headquarters headquarter in headquaters)
            {
                buildingcomboBox.Items.Insert(x, headquarter.buildingName);
                x++;
            }
            buildingcomboBox.SelectedText = currentProject.buildingName;

            numberTextBox.Text = selectedProject.address().number;
            postalcodeTextBox.Text = selectedProject.address().postalCode;

            // Add streets to the combobox
            List<Streets> streets = new Streets().get();
            x = 0;
            foreach (Streets street in streets)
            {
                streetComboBox.Items.Insert(x, street.street_name);
                x++;
            }
            streetComboBox.SelectedText = currentProject.address().street().street_name;

            // Add cities to the combobox
            List<Cities> cities = new Cities().get();
            x = 0;
            foreach (Cities city in cities)
            {
                cityComboBox.Items.Insert(x, city.city_name);
                x++;
            }
            cityComboBox.SelectedText = currentProject.address().city().city_name;

            // Add countries to the combobox
            List<Countries> countries = new Countries().get();
            x = 0;
            foreach (Countries country in countries)
            {
                countryComboBox.Items.Insert(x, country.country_name);
                x++;
            }
            countryComboBox.SelectedText = currentProject.address().country().country_name;

        }

        // Save the current updated user
        private void saveButton_Click(object sender, EventArgs e)
        {
            Projects updatedProject = new Projects();
            updatedProject.project_id = currentProject.project_id;
            updatedProject.name = nameTextbox.Text;
            updatedProject.budget = float.Parse(budgetTextbox.Text);
            updatedProject.allocatedHours = Int32.Parse(allocatedHourstextBox.Text);
            updatedProject.address_id = currentProject.address_id;
            updatedProject.buildingName = buildingcomboBox.Text;
            updatedProject.update("project_id", currentProject.project_id);

            Addresses updatedAddress = new Addresses().find(currentProject.address_id, "address_id").grab();
            updatedAddress.number = numberTextBox.Text;
            updatedAddress.postalCode = postalcodeTextBox.Text;
            updatedAddress.street_id = new Streets().find(streetComboBox.Text, "street_name").grab().street_id;
            updatedAddress.city_id = new Cities().find(cityComboBox.Text, "city_name").grab().city_id;
            updatedAddress.country_id = new Countries().find(countryComboBox.Text, "country_name").grab().country_id;
            updatedAddress.update("address_id", currentProject.address_id);

            currentProject = updatedProject;

            feedbackLabel.Text = "The project has been updated";
            feedbackLabel.ForeColor = System.Drawing.Color.Green;
        }

        // Delete the current project including its address
        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool deleteFeedback = new Projects().find(currentProject.project_id, "project_id").grab().delete();
            bool deleteAddressFeedback = new Addresses().find(currentProject.address_id, "address_id").grab().delete();

            if (deleteFeedback && deleteAddressFeedback)
            {
                feedbackLabel.Text = "The project has been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "The project has NOT been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
