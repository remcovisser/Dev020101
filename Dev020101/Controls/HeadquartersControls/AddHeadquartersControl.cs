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

namespace Dev020101.Controls.HeadquartersControls
{
    public partial class AddHeadquartersControl : UserControl
    {
        public AddHeadquartersControl()
        {
            InitializeComponent();
        }

        // Check if there is an employee with the given BSN
        private bool headquarterUnique(string buildingName)
        {
            if (new Headquarters().find(buildingName, "buildingName").count() == 0)
            {
                return true;
            }
            return false;
        }

        // Save the new headquarter
        private void SaveButtom_Click(object sender, EventArgs e)
        {
            if (headquarterUnique(buildingNameTextbox.Text))
            {
                Headquarters newHeadquarter = new Headquarters();
                newHeadquarter.buildingName = buildingNameTextbox.Text;
                newHeadquarter.rooms = Int32.Parse(roomsTextbox.Text);
                newHeadquarter.rent = float.Parse(rentTextbox.Text);
                newHeadquarter.save();

                feedbackLabel.Text = "The headquarter has been created";
                feedbackLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                feedbackLabel.Text = "There is already an headquarter with that building name";
                feedbackLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
