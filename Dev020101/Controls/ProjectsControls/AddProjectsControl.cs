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

        private void saveButton_Click(object sender, EventArgs e)
        {
            Addresses newAddress = new Addresses();
            newAddress.number = numberTextBox.Text;
            newAddress.postalCode = postalcodeTextBox.Text;
            newAddress.street_id = new Streets().find(streetComboBox.Text, "street_name").grab().street_id;
            newAddress.city_id = new Cities().find(cityComboBox.Text, "city_name").grab().city_id;
            newAddress.country_id = new Countries().find(countryComboBox.Text, "country_name").grab().country_id;
            newAddress.save();

            Projects newProject = new Projects();
            newProject.name = nameTextbox.Text;
            newProject.budget = float.Parse(budgetTextbox.Text);
            newProject.allocatedHours = Int32.Parse(allocatedHourstextBox.Text);
            newProject.buildingName = buildingcomboBox.Text;
            newProject.address_id = new Addresses().last("address_id").grab().address_id;
            newProject.save();

            feedbackLabel.Text = "The project has been created";
            feedbackLabel.ForeColor = System.Drawing.Color.Green;
        }
    }
}
