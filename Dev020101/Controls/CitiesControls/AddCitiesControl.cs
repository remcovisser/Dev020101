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
    public partial class AddCitiesControl : UserControl
    {
        public AddCitiesControl()
        {
            InitializeComponent();
        }

        // Check if there is an employee with the given BSN
        private bool cityUnique(string name)
        {
            if (new Cities().find(name, "city_name").count() == 0)
            {
                return true;
            }
            return false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (cityUnique(nameTextbox.Text))
            {
                Cities newCity = new Cities();
                newCity.city_name = nameTextbox.Text;
                newCity.save();

                feedbackLabel.Text = "The city has been created";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "There is already an city with that name";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
