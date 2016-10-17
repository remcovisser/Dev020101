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
    public partial class AddCountriesControl : UserControl
    {
        public AddCountriesControl()
        {
            InitializeComponent();
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
                Countries newCountry = new Countries();
                newCountry.country_name = nameTextbox.Text;
                newCountry.save();

                feedbackLabel.Text = "The country has been created";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "There is already an country with that name";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
