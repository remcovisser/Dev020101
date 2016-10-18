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

namespace Dev020101.Controls.CitiesControls
{
    public partial class EditCitiesControl : UserControl
    {
        Cities currentCity;

        public EditCitiesControl(Cities selectedCity)
        {
            InitializeComponent();

            // Fill the field with data
            currentCity = selectedCity;
            nameTextbox.Text = selectedCity.city_name;
        }

        // Check if there is a city with the given name
        private bool cityUnique(string name)
        {
            if (name == currentCity.city_name || new Cities().find(name, "city_name").count() == 0)
            {
                return true;
            }
            return false;
        }

        // Save the current updated city
        private void saveButton_Click(object sender, EventArgs e)
        {
            if(cityUnique(nameTextbox.Text))
            {
                Cities updatedCity = new Cities();
                updatedCity.city_id = currentCity.city_id;
                updatedCity.city_name = nameTextbox.Text;
                updatedCity.update("city_id", currentCity.city_id);

                currentCity = updatedCity;

                feedbackLabel.Text = "The city has been updated";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "There is already a city with that name";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        // Delete the current city
        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool deleteFeedback = new Cities().find(currentCity.city_id, "city_id").grab().delete();

            if (deleteFeedback)
            {
                feedbackLabel.Text = "The city has been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "The city has NOT been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
