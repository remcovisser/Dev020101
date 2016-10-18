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

namespace Dev020101.Controls.StreetsControls
{
    public partial class EditStreetsControl : UserControl
    {
        Streets currentStreet;

        public EditStreetsControl(Streets selectedStreet)
        {
            InitializeComponent();

            // Fill the field with data
            currentStreet = selectedStreet;
            nameTextbox.Text = selectedStreet.street_name;
        }

        // Check if there is a street with the given name
        private bool streeetUnique(string name)
        {
            if (name == currentStreet.street_name || new Streets().find(name, "street_name").count() == 0)
            {
                return true;
            }
            return false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (streeetUnique(nameTextbox.Text))
            {
                Streets updatedStreet = new Streets();
                updatedStreet.street_id = currentStreet.street_id;
                updatedStreet.street_name = nameTextbox.Text;
                updatedStreet.update("street_name", currentStreet.street_name);

                currentStreet = updatedStreet;

                feedbackLabel.Text = "The street has been updated";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "There is already a street with that name";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool deleteFeedback = new Streets().find(currentStreet.street_id, "street_id").grab().delete();

            if (deleteFeedback)
            {
                feedbackLabel.Text = "The street has been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "The street has NOT been deleted";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
