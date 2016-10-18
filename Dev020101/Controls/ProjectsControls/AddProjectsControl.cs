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
    public partial class AddProjectsControl : UserControl
    {
        public AddProjectsControl()
        {
            InitializeComponent();

            // Add data to the comboboxes
            List<Headquarters> headquaters = new Headquarters().get();
            int x = 0;
            foreach (Headquarters headquarter in headquaters)
            {
                buildingcomboBox.Items.Insert(x, headquarter.buildingName);
                x++;
            }

            List<Addresses> addresses = new Addresses().get();
            x = 0;
            foreach (Addresses addres in addresses)
            {
                string addressName = addres.address_id + " = " + addres.street_name + " " + addres.number + " - " + addres.city_name + " - " + addres.country_name;
                addresscomboBox.Items.Insert(x, addressName);
                x++;
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Projects newProject = new Projects();
            newProject.name = nameTextbox.Text;
            newProject.budget = float.Parse(budgetTextbox.Text);
            newProject.allocatedHours = Int32.Parse(allocatedHourstextBox.Text);
            newProject.buildingName = buildingcomboBox.Text;
            newProject.address_id = Int32.Parse(addresscomboBox.Text.Split('=').First().Trim(' '));
            newProject.save();

            feedbackLabel.Text = "The project has been created";
            feedbackLabel.ForeColor = System.Drawing.Color.Green;
        }
    }
}
