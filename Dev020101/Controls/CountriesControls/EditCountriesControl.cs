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

namespace Dev020101.Controls.CountriesControls
{
    public partial class EditCountriesControl : UserControl
    {
        Countries currentCountry;

        public EditCountriesControl(Countries selectedCountry)
        {
            InitializeComponent();

            // Fill the field with data
            currentCountry = selectedCountry;
            nameTextbox.Text = selectedCountry.country_name;
        }

        // Check if there is an country with the given BSN
        private bool countryUnique(string name)
        {
            if (new Countries().find(name, "country_name").count() == 0)
            {
                return true;
            }
            return false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (countryUnique(nameTextbox.Text))
            {
                Countries updatedCountry = new Countries();
                updatedCountry.country_name = nameTextbox.Text;
                updatedCountry.update("country_name", currentCountry.country_name);

                currentCountry = updatedCountry;

                feedbackLabel.Text = "The country has been updated";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "There is already a country with that name";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool deleteFeedback = new Countries().find(currentCountry.country_name, "country_name").grab().delete();

            if (deleteFeedback)
            {
                feedbackLabel.Text = "The country has been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "The country has NOT been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
