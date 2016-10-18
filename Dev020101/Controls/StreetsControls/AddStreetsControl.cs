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
    public partial class AddStreetsControl : UserControl
    {
        public AddStreetsControl()
        {
            InitializeComponent();
        }

        // Check if there is a street with the given name
        private bool streeetUnique(string name)
        {
            if (new Streets().find(name, "street_name").count() == 0)
            {
                return true;
            }
            return false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (streeetUnique(nameTextbox.Text))
            {
                Streets newStreet = new Streets();
                newStreet.street_name = nameTextbox.Text;
                newStreet.save();

                feedbackLabel.Text = "The street has been created";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "There is already a street with that name";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
