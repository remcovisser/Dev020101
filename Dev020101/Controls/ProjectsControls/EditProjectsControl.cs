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

            // Add addresses to the combobox
            List<Addresses> addresses = new Addresses().get();
            x = 0;
            foreach (Addresses addres in addresses)
            {
                string addressName = addres.address_id + " = " + addres.street().street_name + " " + addres.number;
                addresscomboBox.Items.Insert(x, addressName);
                x++;
            }
            Addresses projectAdress = currentProject.address();
            string selectedAddress = projectAdress.address_id + " = " + projectAdress.street_id + " " + projectAdress.number;
            addresscomboBox.SelectedText = selectedAddress;
        }

        // Save the current updated user
        private void saveButton_Click(object sender, EventArgs e)
        {
            Projects updatedProject = new Projects();
            updatedProject.project_id = currentProject.project_id;
            updatedProject.name = nameTextbox.Text;
            updatedProject.budget = float.Parse(budgetTextbox.Text);
            updatedProject.allocatedHours = Int32.Parse(allocatedHourstextBox.Text);
            updatedProject.buildingName = buildingcomboBox.Text;
            updatedProject.address_id = Int32.Parse(addresscomboBox.Text.Split('=').First().Trim(' '));
            updatedProject.update("project_id", currentProject.project_id);

            currentProject = updatedProject;

            feedbackLabel.Text = "The project has been updated";
            feedbackLabel.ForeColor = System.Drawing.Color.Green;
        }

        // Delete the current user
        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool deleteFeedback = new Projects().find(currentProject.project_id, "project_id").grab().delete();

            if (deleteFeedback)
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
